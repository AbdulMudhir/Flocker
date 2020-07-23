

const offerButton = document.querySelector(".make-offer");
const offerContainer = document.querySelector(".offer-container");
const closeOffer = document.querySelector(".close-offerform");

closeOffer.addEventListener("click", function () {
    offerContainer.style.display = "none";
})

offerButton.addEventListener("click", function () {

    offerContainer.style.display ="block";

})

const offerForm = document.querySelector("#offer-form");

offerForm.addEventListener("submit", function (event) {
    event.preventDefault();

    let form = new FormData(this);


    const ajax = new XMLHttpRequest();


    ajax.open("Post", "/product/MakeOffer", true);
    ajax.responseType = "json";

    ajax.onload = function () {
        if (this.status == 200) {

            switch (this.response.message) {

                case "Offer has been sent":
                    

                    var pendingButton = document.createElement("a");
                    pendingButton.setAttribute("class", "offer-pending");
                    pendingButton.textContent = "Offer Pending"
                    offerContainer.remove();

                    const mainContainer = document.querySelector(".product-info");
                    mainContainer.replaceChild(pendingButton, offerButton);


                    break;

               
                    
            }
            
        }
    }

    ajax.send(form);



})