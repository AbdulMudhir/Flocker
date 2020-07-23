

const sortByButton = document.querySelector(".sortby");

sortByButton.addEventListener("click", toggleOption);

const optionMenu = document.querySelector(".options");

function toggleOption() {

    
    let optionMenuDisplay = window.getComputedStyle(optionMenu).display;

    if (optionMenuDisplay === "none") {

        optionMenu.style.display = "block";
    }
    else {
        optionMenu.style.display = "none";
    }
    


}

const options = document.querySelectorAll(".choice");

for (let i = 0; i < options.length; i++) {

    options[i].addEventListener("click", sortByAjax);
}

function sortByAjax(event) {

    const choiceValue = event.target.textContent;

    const ajax = new XMLHttpRequest();

    const categoryId = sortByButton.attributes["id"].value;

    ajax.open("Post", "/Category/SortBy", true);
    ajax.setRequestHeader("Content-Type", "application/json");
    ajax.responseType = "json";


    ajax.onload = function(){

        if (this.status == 200) {

            const response = this.response;

            if (response.success == "true") {

                const data = response.data;
                const categoryContainer = document.querySelector(".new-content");

                let categoryTemplate = `<ul class="grid-layout-4">`;

                if (choiceValue === "Lowest Price") {

                    for (let i = 0; i < data.length; i++) {

                        let product = data[i];


                        let imgurl = product.Images[0].Image.split("~")[1];


                        let cardTemplate = `

                        <li class="card-container ">
                                <a  href= "/Product/Detail/${product.ProductId}" class="card">
                        <img class="card-img" src="${imgurl}" />
                        <div class="card-title">
                            <h4>${product.Name}</h4>`


                        if (product.Price < 0) {
                            cardTemplate += ` <h5 class="card-price">Free</h5>`;
                        }
                        else {

                            cardTemplate += `<h5 class="card-price">£${product.Price}</h5>`
                        }

                        categoryTemplate += cardTemplate;

                    }
                }

                else {

                    for (let i = data.length -1; i >= 0; i--) {

                        let product = data[i];


                        let imgurl = product.Images[0].Image.split("~")[1];


                        let cardTemplate = `

                        <li class="card-container ">
                                <a  href= "/Product/Detail/${product.ProductId}" class="card">
                        <img class="card-img" src="${imgurl}" />
                        <div class="card-title">
                            <h4>${product.Name}</h4>`


                        if (product.Price < 0) {
                            cardTemplate += ` <h5 class="card-price">Free</h5>`;
                        }
                        else {

                            cardTemplate += `<h5 class="card-price">£${product.Price}</h5>`
                        }

                        categoryTemplate += cardTemplate;

                    }


                }
                    categoryTemplate += `
                        </div>
                                    </a>
                                    </li>
                                    </ul>`;
                


              

                



                categoryContainer.innerHTML = categoryTemplate;


            }
            
        }

    }

    let data = {
        CategoryId: parseInt(categoryId),
    };

    ajax.send(parseInt(categoryId));

    optionMenu.style.display = "none";
}