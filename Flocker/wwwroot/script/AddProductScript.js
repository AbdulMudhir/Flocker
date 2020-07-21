

const descriptionBox = document.querySelector(".description-content");



descriptionBox.addEventListener("input", function (event) {

    const descriptionLengthCounter = document.querySelector(".description-length");

    let inputCharacterLength = descriptionBox.value.length;

    const maxCharacterLength = descriptionBox.attributes["data-val-maxlength-max"].value;



    descriptionLengthCounter.textContent = `${inputCharacterLength}/${maxCharacterLength}`



});


const imgInput = document.querySelector(".input-img");

const imgPreviewContainer = document.querySelector(".preview-container");


imgInput.addEventListener("change", function (event) {

    let imagesUploaded = event.target.files;

    const imgSizeValidation = document.querySelector(".img-size-validation");



    if (imagesUploaded.length > 8) {

        alert("You are only allowed to upload a maximum of 10 files");

        return false;
    }

    else {

        for (let i = 0; i < imagesUploaded.length; i++) {



            if (imagesUploaded[i].size / 1024 / 1024 > 8) {

                imgSizeValidation.style.display = "inline-block";

            }

            else {

                let imagePreview = document.createElement("div");
                imagePreview.setAttribute("class", "picture");

                let totalImagesUploaded = imgPreviewContainer.childElementCount;

                imageTemplate = ` <img class="remove" src="/Image/close.svg" />

                            <img src="${URL.createObjectURL(imagesUploaded[i])}" />`

                imagePreview.innerHTML = imageTemplate;

                imgPreviewContainer.appendChild(imagePreview);

            }


    }


    }
    
    setupImgDelete()

});

function setupImgDelete() {

    
    let removeButton = document.getElementsByClassName("remove");


    for (var i = 0; i < removeButton.length; i++) {

        removeButton[i].addEventListener("click", function (event) {

          
           event.target.parentElement.remove();

        }

        )
    }


}



async function ImgsUrlToBlob(form, imgUrl) {

    return Promise.all(imgUrl.map(url => fetch(url)))
        .then(response =>
            Promise.all(response.map(res => res.blob())))
        .then(blob => {
            for (let i = 0; i < blob.length; i++) {

                let extension = blob[i].type.split("/").pop();

                let imgFile = new File([blob[i]], `imgUpload${i}.${extension}`);
             
                form.append("Images", imgFile)
            }

        })
}



function DisplayErrors(errors) {


    let keyObjects = Object.keys(errors)

    for (let i = 0; i < keyObjects.length; i++) {

        if (keyObjects[i].length > 0) {

            let validationBox = document.querySelector(`span[data-valmsg-for="${keyObjects[i]}"]`)

            if (validationBox !== null) {
                validationBox.innerHTML = errors[keyObjects[i]];
            }
        }

        
    }

}


async function AjaxForm(event) {
    event.preventDefault();

    // reset input container
    imgInput.value = "";


    const form = new FormData(event.target);


    let imgUrl = [];



   
    // using 1 as dom objects dont start from 0

    for (var i = 1; i <= imgPreviewContainer.childElementCount; i++) {

            let pictureContainer = imgPreviewContainer.childNodes[i];

            let previewImage = pictureContainer.lastChild

        if (previewImage !== null) {


            imgUrl.push(previewImage.src)

        }

        else {
 
        }
    }




    ImgsUrlToBlob(form, imgUrl).
        then(() => {

            let ajax = new XMLHttpRequest();


            ajax.open("Post", "/product/add", true);
            ajax.responseType = 'json';


            ajax.onload = function () {


                let response = this.response;

                if (this.status == 200) {


                    if (response.success == "true") {

                        window.location.replace(`/Product/detail/${response.id}`)

                    }

                    else {

                        DisplayErrors(response.errors);
                    

                    }

                }

                else {

                    alert("Looks like there is an issue with the server, please try again in few minutes");
                }

            }


            ajax.send(form);

        }
       

    )
  

  
}





























const submitButton = document.querySelector("form");

submitButton.addEventListener("submit", AjaxForm )


