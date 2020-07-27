

const addWishList = document.querySelector(".add-watchlist");


addWishList.addEventListener("click", addOrRemoveWishList)

function addOrRemoveWishList(event) {

   
    const requestText = event.target.textContent;
    const productID = event.target.attributes["value"].value;

    



    const ajax = new XMLHttpRequest();
    ajax.open("Post", "/Profile/Watchlist", true);

    ajax.setRequestHeader("content-type", "application/json");
    ajax.responseType = "json";

    ajax.onload = function () {

        if (this.status === 200) {

            if (this.response.success === "true") {

                if (this.response.success === "true") {

                    console.log(requestText)

                    if (requestText === "Add to watchlist") {


                        event.target.innerHTML = `<img src="/Image/heart.png">Remove watchlist`;
                        //event.target.textContent = "Remove watchlist"
                    }
                    else {
                        event.target.innerHTML = `<img src="/Image/heart.png">Add to watchlist`;
                     
                    }
                }


            }

            else {
                alert("looks like there's an issue with server. Please try again in few minutes")
            }

        }
    }

    const data = {

        ProductId: parseInt(productID),
        Message: requestText

    }



    ajax.send(JSON.stringify(data));

}
