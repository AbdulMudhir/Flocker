



const descriptionBox = document.querySelector(".description-content");


descriptionBox.addEventListener("input", updateDescriptionCount);



function updateDescriptionCount() {
    const descriptionLengthCounter = document.querySelector(".description-length");

    let inputCharacterLength = descriptionBox.value.length;

    const maxCharacterLength = descriptionBox.attributes["data-val-maxlength-max"].value;



    descriptionLengthCounter.textContent = `${inputCharacterLength}/${maxCharacterLength}`

}



updateDescriptionCount();








const imgInput = document.querySelector(".input-img");

const imgPreviewContainer = document.querySelector(".preview-container");



imgPreviewContainer.addEventListener("DOMNodeInserted", function (event) {

    if (this.childElementCount >= 8) {
        let imglabel = document.querySelector(".custom-input-block");
        imglabel.style.cursor = "not-allowed";
        imglabel.style.backgroundColor = "#636262";


        imgInput.disabled = true;

    }

})

imgPreviewContainer.addEventListener("DOMNodeRemoved", function (event) {

    if (this.childElementCount <= 8) {
        let imglabel = document.querySelector(".custom-input-block");
        imglabel.style.cursor = "pointer";
        imglabel.style.backgroundColor = "#F6F6F6";

        imgInput.disabled = false;

    }

})



imgInput.addEventListener("change", function (event) {

    let imagesUploaded = event.target.files;

    const imgSizeValidation = document.querySelector(".img-size-validation");


    const totalImagesToUpload = imagesUploaded.length;

    const totalImagesInContainer = imgPreviewContainer.childElementCount;



    if (totalImagesToUpload < 8 && totalImagesInContainer < 8) {



        if (totalImagesToUpload <= (8 - totalImagesInContainer )) {

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

           
            setupImgDelete()
            return true;
        }


    }

 
     alert("You are only allowed to upload a maximum of 8 files");

        return false;






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
setupImgDelete()


async function ImgsUrlToBlob(form, imgUrl) {

    return Promise.all(imgUrl.map(url => fetch(url)))
        .then(response =>
            Promise.all(response.map(res => res.blob())))
        .then(blob => {
            for (let i = 0; i < blob.length; i++) {

                let extension = blob[i].type.split("/").pop();

                let imgFile = new File([blob[i]], `imgUpload${i}.${extension}`);

     
                form.append("ImagesFiles", imgFile)
            }

        })
}



function DisplayErrors(errors) {

    let keyObjects = Object.keys(errors)


    for (let i = 0; i < keyObjects.length; i++) {


        let validationBox = document.querySelector(`span[data-valmsg-for="${keyObjects[i]}"]`);

        if (errors[keyObjects[i]].length > 0) {



            if (validationBox !== null) {
                validationBox.innerHTML = errors[keyObjects[i]];
                validationBox.style.display = "inline-Block";
            }
        }
        else {
            if (validationBox !== null) {
                validationBox.innerHTML = "";
                validationBox.style.display = "None";
            }
        }


    }

}


function imgURLsFromContainer() {

    let imgUrl = [];



    let imgsInPreviewContainer = document.getElementsByClassName("picture");



    // using 1 as dom objects dont start from 0

    for (var i = 0; i < imgsInPreviewContainer.length; i++) {



        let previewImage = imgsInPreviewContainer[i].lastElementChild



        if (previewImage !== null) {


            imgUrl.push(previewImage.src)

        }

        else {

        }
    }

    return imgUrl;
}