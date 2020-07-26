
const approveButton = document.querySelectorAll(".approve");
const declineButton = document.querySelectorAll(".decline");

for (let i = 0; i < approveButton.length; i++) {
    approveButton[i].addEventListener("click", approveOrDecline)
    declineButton[i].addEventListener("click", approveOrDecline)
}



function approveOrDecline(event) {

    const confirmContainer = event.target.parentElement;


    const productID = confirmContainer.querySelector(`input[name="ProductId"]`).value;
    const offerID = confirmContainer.querySelector(`input[name="OfferId"]`).value;


    const ajax = new XMLHttpRequest();
    ajax.open("Post", "/Profile/ApproveOrDeclineOffer", true);

    ajax.setRequestHeader("content-type", "application/json");
    ajax.responseType = "json";
    ajax.onload = function () {

        if (this.status === 200) {

            if (this.response.success === "true") {

                event.target.parentElement.parentElement.remove()
            }

            else {
                alert("looks like there's an issue with server. Please try again in few minutes")
            }

        }
    }

    const data = {

        ProductId: parseInt(productID),
        OfferId: parseInt(offerID),
        Message: event.target.textContent

    }



    ajax.send(JSON.stringify(data));

}
