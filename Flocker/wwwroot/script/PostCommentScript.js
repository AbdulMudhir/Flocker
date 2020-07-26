


const submitButton = document.querySelector(".submit-comment");

submitButton.addEventListener("click", postComment)

function postComment(event) {

    const confirmContainer = event.target.parentElement.parentElement;


    const productID = confirmContainer.querySelector(`input[name="ProductId"]`).value;

    const loggedInUser = confirmContainer.querySelector(`input[name="UserLoggedIn"]`).value;
    const loggedInUserImg = confirmContainer.querySelector(".seller-img").attributes["src"].value;

    const textContent = confirmContainer.querySelector(".comment-input").value;
    const errorBox = confirmContainer.querySelector(".field-validation-error");

    if (textContent.length > 500) {

       
        errorBox.style.display = "block";
        errorBox.textContent = "Comment cannot be longer than 500 character long."
    }
    else if (textContent.length < 5)
    {
        errorBox.style.display = "block";
        errorBox.textContent = "Comment cannot be less than 5 character long"
    }
    else {
        errorBox.style.display = "none";

    

    const ajax = new XMLHttpRequest();
    ajax.open("Post", "/Product/PostComment", true);

    ajax.setRequestHeader("content-type", "application/json");
    ajax.responseType = "json";

    ajax.onload = function () {

        if (this.status === 200) {

            if (this.response.success === "true") {

                const commentBoxContainer = document.querySelector(".comment-box-container");

                confirmContainer.querySelector(".comment-input").value = "";

                const commentTemplate = 
                    `
            <div class= "comment-box">
            <div class="comment">

                            <div class="comment-profile">
                                <img class="seller-img" src="${loggedInUserImg}" />
                                <h1 class="user-comment">${loggedInUser}</h1>
                                <div class="comment-date">
                                    ${this.response.date}
                                </div>
                            </div>
                            <p class="comment-text">

                                    ${textContent}
                               
                            </p>

                        </div>



                    </div>
</div>

`

             

                commentBoxContainer.innerHTML = commentTemplate + commentBoxContainer.innerHTML;
                
            }

            else {
                alert("looks like there's an issue with server. Please try again in few minutes")
            }

        }
    }

    const data = {

        ProductId: parseInt(productID),
        Content: textContent

    }



    ajax.send(JSON.stringify(data));
    }
}
