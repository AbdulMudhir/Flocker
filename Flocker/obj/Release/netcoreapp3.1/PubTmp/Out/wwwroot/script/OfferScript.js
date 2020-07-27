
const deleteProductButton = document.querySelectorAll(".delete");

const confirmationBoxes = document.querySelectorAll(".confirmation-box");

const noButtons = document.querySelectorAll(".no-button");

const yesButtons = document.querySelectorAll(".yes-button")


for (let i = 0; i < deleteProductButton.length; i++) {

    deleteProductButton[i].addEventListener("click", confirmationBoxDisplay)
}


function confirmationBoxDisplay(event) {


    event.preventDefault();

    for (let i = 0; i < confirmationBoxes.length; i++) {
        confirmationBoxes[i].style.display = "none";
        confirmationBoxes[i].addEventListener("submit", deleteOffer)
    }

    const confirmationBox = event.target.parentElement.querySelector(".confirmation-box");


    confirmationBox.style.display = "block";

}



for (let i = 0; i < noButtons.length; i++) {
    noButtons[i].addEventListener("click", noOption);
}

function noOption(event) {

    event.preventDefault();

    event.target.parentElement.style.display = "none";

}


for (let i = 0; i < yesButtons.length; i++) {

    yesButtons[i].addEventListener("click", deleteOffer)
}


function deleteOffer(event) {

    const confirmContainer = event.target.parentElement;

    const productID = confirmContainer.querySelector(`input[name="ProductId"]`).value;
    const offerID = confirmContainer.querySelector(`input[name="OfferId"]`).value;


    const ajax = new XMLHttpRequest();
    ajax.open("Post", "/Profile/DeleteOffer", true);

    ajax.setRequestHeader("content-type", "application/json");
    ajax.responseType = "json";

    ajax.onload = function () {

        if (this.status === 200) {

            if (this.response.success === "true") {
                event.target.parentElement.parentElement.parentElement.remove()
            }

            else {
                alert("looks like there's an issue with server. Please try again in few minutes")
            }
            
        }
    }

    const data = {

        ProductId: parseInt(productID),
        OfferId:parseInt(offerID)

    }



    ajax.send(JSON.stringify(data));

}

