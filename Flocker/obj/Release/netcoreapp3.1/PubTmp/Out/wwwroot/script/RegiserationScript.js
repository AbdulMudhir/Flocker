

const imgPreview = document.querySelector(".custom-avatar-block");

const inputImg = document.querySelector(".avatar-img");




inputImg.addEventListener("change", function (event) {

    let imagesUploaded = event.target.files;

    const imgSizeValidation = document.querySelector(".img-size-validation");





            for (let i = 0; i < imagesUploaded.length; i++) {



                if (imagesUploaded[i].size / 1024 / 1024 > 8) {

                    imgSizeValidation.style.display = "inline-block";

                }

                else {

                    //URL.createObjectURL(imagesUploaded[i])

                    const imgurl = URL.createObjectURL(imagesUploaded[i]);

                    imgPreview.style.backgroundImage = `url(${imgurl})`
                    imgPreview.style.opacity = "1";

                }


            }


            return true;
      


 




});