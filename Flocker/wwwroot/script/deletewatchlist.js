
const deleteProductButton = document.querySelectorAll(".delete");

const confirmationBoxes = document.querySelectorAll(".confirmation-box");

const noButtons = document.querySelectorAll(".no-button");

const yesButtons = document.querySelectorAll(".yes-button");

for (let i = 0; i < deleteProductButton.length; i++) {

    deleteProductButton[i].addEventListener("click", confirmationBoxDisplay)
}


function confirmationBoxDisplay(event) {


    event.preventDefault();

    for (let i = 0; i < confirmationBoxes.length; i++) {
        confirmationBoxes[i].style.display = "none";
    }

    const confirmationBox = event.target.parentElement.querySelector(".confirmation-box");


    confirmationBox.style.display = "block";

}


for (let i = 0; i < yesButtons.length; i++) {

    yesButtons[i].addEventListener("click", deleteProduct)
}

for (let i = 0; i < noButtons.length; i++) {
    noButtons[i].addEventListener("click", noOption);
}

function noOption(event) {

    event.preventDefault();

    event.target.parentElement.style.display = "none";

}




function deleteProduct(event) {

    const productId = event.target.parentElement.querySelector(`input[name=ProductId]`).value

    
    const ajax = new XMLHttpRequest();
    ajax.open("Post", "/Profile/WatchList", true);

    ajax.setRequestHeader("content-type", "application/json");
    ajax.responseType = "json";
    ajax.onload = function () {

        if (this.status === 200) {

           

            if (this.response.success === "true") {

                event.target.parentElement.parentElement.parentElement.remove()

            }
            else {
                alert("Sorry looks like there's an issue please try again in few minutes")
            }
        }
    }

    const data = {
        ProductId: parseInt(productId)
    }


    ajax.send(JSON.stringify(data));

}

