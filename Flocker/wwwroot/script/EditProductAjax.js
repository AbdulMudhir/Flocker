

document.querySelector("#product-submittionform").addEventListener("submit", AjaxForm);


const deleteProductButton = document.querySelector(".delete-product-button");

deleteProductButton.addEventListener("click", function (event) {

    event.preventDefault();

    const confirmationBox = document.querySelector(".confirmation-box");


    confirmationBox.style.display = "block";

})


const noButton = document.querySelector(".no-button");

noButton.addEventListener("click",  function(event){

    event.preventDefault();

    event.target.parentElement.style.display = "none";

})



async function AjaxForm(event) {
    event.preventDefault();

    // reset input container
    imgInput.value = "";


    const form = new FormData(event.target);





    ImgsUrlToBlob(form, imgURLsFromContainer()).
        then(() => {

            let ajax = new XMLHttpRequest();


            ajax.open("Post", "/product/Edit", true);
            ajax.responseType = 'json';


            ajax.onload = function () {


                let response = this.response;

                if (this.status == 200) {


                    if (response.success == "true") {

                        alert("Your product has been updated")

                    }

                    else {

                        DisplayErrors(response.Errors);
                    

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


