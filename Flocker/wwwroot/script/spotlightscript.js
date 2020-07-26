

const spotlightButton = document.querySelectorAll(".spotlight-checkbox");


for (let i = 0; i < spotlightButton.length; i++) {

    spotlightButton[i].addEventListener("click", spotlight)
}


function spotlight(event) {


    const productID = event.target.parentElement.querySelector(`input[name="ProductId"]`).value;


    console.log(productID);


    const ajax = new XMLHttpRequest();
    ajax.open("Post", "/Product/SpotlightProduct", true);

    ajax.setRequestHeader("content-type", "application/json");
    ajax.responseType = "json";

    ajax.onload = function () {

        if (this.status === 200) {

            if (this.response.success === "true") {

                console.log("i am here")


            }

            else {
                alert("looks like there's an issue with server. Please try again in few minutes")
            }

        }
    }

 


    ajax.send(parseInt(productID));

}
