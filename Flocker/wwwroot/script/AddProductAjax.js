

async function AjaxForm(event) {
    event.preventDefault();

    // reset input container
    imgInput.value = "";


    const form = new FormData(event.target);




    ImgsUrlToBlob(form, imgURLsFromContainer()).
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


