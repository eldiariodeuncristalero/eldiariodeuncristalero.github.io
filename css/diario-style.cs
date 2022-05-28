.container-iframe {
    position: relative;
    width: 100%;
    overflow: hidden;
    padding-top: 100%;
    /* 1:1 Aspect Ratio */
}

.responsive-iframe {
    position: absolute;
    top: 0;
    left: 0;
    bottom: 0;
    right: 0;
    width: 100%;
    height: 100%;
    border: none;
}

.responsive5 {
    padding: 0 6px;
    margin: 6px 0;
    float: left;
    width: 20%;
    display: grid;
}

@media only screen and (max-width: 700px) {
    .responsive5 {
        width: 50%;
        margin: 6px 0;
        padding: 0 6px;
        display: grid;
        width: 20%;
    }
}

@media only screen and (max-width: 1200px) {
    .responsive5 {
        width: 50%;
        margin: 6px 0;
        padding: 0 6px;
        display: grid;
        width: 20%;
    }
}

@media only screen and (max-width: 500px) {
    .responsive5 {
        width: 50%;
        /*  margin: 6px 0;*/
        margin: 6px 0;
        padding: 0 6px;
        display: grid;
        width: 25%;
    }
}

.img {
    max-width: 400px;
    width: 100%;
    height: auto;
    border-radius: 5px;
    transition: 0.3s;
    margin: 0 auto;
    vertical-align: middle;
}

.responsiveg {
    padding: 0 6px;
    margin: 6px 0;
    float: left;
    width: 20%;
    display: grid;
}

@media only screen and (max-width: 700px) {
    .responsiveg {
        width: 50%;
        margin: 6px 0;
        padding: 0 6px;
        display: grid;
        width: 33.33%;
    }
}

@media only screen and (max-width: 1200px) {
    .responsiveg {
        width: 50%;
        margin: 6px 0;
        padding: 0 6px;
        display: grid;
        width: 33.33%;
    }
}

@media only screen and (max-width: 500px) {
    .responsiveg {
        width: 50%;
        margin: 6px 0;
        padding: 0 6px;
        display: grid;
        width: 50%;
    }
    /* Responsive layout - when the screen is less than 700px wide, make the two columns stack on top of each other instead of next to each other */
    /* Responsive layout - when the screen is less than 400px wide, make the navigation links stack on top of each other instead of next to each other */
}

.img-cucu {
    width: 100%;
    height: auto;
    border-radius: 5px;
    cursor: pointer;
    transition: 0.3s;
    align-items: center;
}

.rosa {
    color: #F06365;
}

.pink {
    color: #EC344D;
}

.cucu {
    color: #BD1455;
}

.container-name {
    display: flex;
    justify-content: center;
    align-items: center;
}

.container-name .box {
    display: flex;
    justify-content: center;
    flex-direction: column;
}

.container-name .box .title {
    width: 100%;
    display: flex;
    align-items: center;
    height: 50px;
}

.container-name .box .title .block {
    width: 0%;
    height: inherit;
    /*  
background: linear-gradient(45deg, #042461 0%, rgba(225, 5, 34, 0) 70%), linear-gradient(135deg, #340447 10%, rgba(49, 5, 209, 0) 80%), linear-gradient(225deg, #0f053a 10%, rgba(10, 219, 216, 0) 80%), linear-gradient(315deg, #050813 100%, rgba(9, 245, 5, 0) 70%);
background: linear-gradient( to right, #e91e63, #d4232c, #ce6f30, #e9d51e, #23d458, #1ec0e9, #981ee9, #23d458, #1ea9e9); */
    background-position: center 0%;
    animation: background-slide 1s infinite linear;
    position: absolute;
    animation: mainBlock 2s cubic-bezier(0.74, 0.06, 0.4, 0.92) forwards;
    display: flex;
}

.container-name .box .role {
    width: 100%;
    position: relative;
    display: flex;
    align-items: center;
    height: 30px;
    margin-top: -10px;
}

.container-name .box .role .block {
    width: 0%;
    height: inherit;
    background: linear-gradient( to right, #e91e63, #d4235e, #ce3065, #e91e63, #d4235e, #e91e63);
    background-position: center 0%;
    animation: background-slide 1s infinite linear;
    position: absolute;
    animation: secBlock 2s cubic-bezier(0.74, 0.06, 0.4, 0.92) forwards;
    animation-delay: 2s;
    display: flex;
}

.container-name .box .role p {
    animation: secFadeIn 2s forwards;
    animation-delay: 3.2s;
    opacity: 0;
    font-weight: 800;
    font-family: "Lato";
    color: #ddcccc;
    font-size: 20px;
    letter-spacing: 6px;
    padding-top: 30px;
    padding-bottom: 30px;
    margin-top: 33px;
}

@keyframes mainBlock {
    0% {
        width: 0%;
        left: 0;
    }
    50% {
        width: 100%;
        left: 0;
    }
    100% {
        width: 0;
        left: 100%;
    }
}

@keyframes secBlock {
    0% {
        width: 0%;
        left: 0;
    }
    50% {
        width: 100%;
        left: 0;
    }
    100% {
        width: 0;
        left: 100%;
    }
}

@keyframes secFadeIn {
    0% {
        opacity: 0;
    }
    100% {
        opacity: 0.5;
    }
}
/* small */

@media (max-width:600px) {
    .container-name .box {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
    }
    .container-name .box .title {
        display: flex;
        align-items: center;
        justify-content: center;
    }
    .container-name .box .title .block {
        width: 0%;
        height: inherit;
        background: linear-gradient(45deg, #042461 0%, rgba(225, 5, 34, 0) 70%), linear-gradient(135deg, #340447 10%, rgba(49, 5, 209, 0) 80%), linear-gradient(225deg, #0f053a 10%, rgba(10, 219, 216, 0) 80%), linear-gradient(315deg, #050813 100%, rgba(9, 245, 5, 0) 70%);
        /*   background: linear-gradient( to right, #e91e63, #d4232c, #ce6f30, #e9d51e, #23d458, #1ec0e9, #981ee9, #23d458, #1ea9e9); */
        background-position: center 0%;
        animation: background-slide 1s infinite linear;
        position: absolute;
        animation: mainBlock 2s cubic-bezier(0.74, 0.06, 0.4, 0.92) forwards;
        display: flex;
        align-items: center;
        justify-content: center;
        height: 40px;
    }
    .container-name .box .role {
        width: 100%;
        position: relative;
        display: flex;
        align-items: center;
    }
    .container-name .box .role .block {
        width: 0%;
        background: linear-gradient( to right, #e91e63, #d4235e, #ce3065, #e91e63, #d4235e, #e91e63);
        background-position: center 0%;
        animation: background-slide 1s infinite linear;
        position: absolute;
        animation: secBlock 2s cubic-bezier(0.74, 0.06, 0.4, 0.92) forwards;
        animation-delay: 2s;
        display: flex;
    }
    .container-name .box .role p {
        animation: secFadeIn 2s forwards;
        animation-delay: 3.2s;
        opacity: 0;
        font-weight: 800;
        word-spacing: 0px;
        letter-spacing: 0px;
        /*  line-height: 1.5px; */
        align-items: center;
    }
    @keyframes mainBlock {
        0% {
            width: 0%;
            left: 0;
        }
        50% {
            width: 100%;
            left: 0;
        }
        100% {
            width: 0;
            left: 100%;
        }
    }
    @keyframes secBlock {
        0% {
            width: 0%;
            left: 0;
        }
        50% {
            width: 100%;
            left: 0;
        }
        100% {
            width: 0;
            left: 100%;
        }
    }
    @keyframes secFadeIn {
        0% {
            opacity: 0;
        }
        100% {
            opacity: 0.5;
        }
    }
}
/* small */

@media (max-width:600px) {
    .w3-hide-small {
        display: none!important
    }
}
/* medium */

@media (max-width:992px) and (min-width:601px) {
    .w3-hide-medium {
        display: none!important
    }
}
/* large */

@media (min-width:993px) {
    .w3-hide-large {
        display: none!important
    }
}
/*-------------------------------------------------------------------*/

.background-icon-black-1B1C24 {
    justify-content: center;
    gap: 2rem;
    padding: 3rem;
    background-color: #000105;
    background-image: url("img/lamp-icon-black-1B1C24.svg");
    /*  background-color: #1086B5; 
    background-image: url("lamp-icon.svg"); */
    align-items: center;
    text-align: center;
    padding: 3rem;
}

p {
    margin: 0
}

body {
    font-size: 15px;
    line-height: 1.5;
    font-family: "Roboto", sans-serif;
    margin: 0
}
/* Extract from normalize.css by Nicolas Gallagher and Jonathan Neal git.io/normalize */

.w3-container:after,
.w3-container:before {
    content: "";
    display: table;
    clear: both
}

@media (max-width:600px) {
    .w3-hide-small {
        display: none!important
    }
}

@media (min-width:993px) {
    .w3-hide-large {
        display: none!important
    }
}

@media (max-width:992px) and (min-width:601px) {
    .w3-hide-medium {
        display: none!important
    }
}

.w3-container {
    padding: 0.01em 16px
}

.w3-center {
    text-align: center!important
}

.responsive5 {
    padding: 0 6px;
    margin: 6px 0;
    float: left;
    width: 20%;
    display: grid;
}

@media only screen and (max-width: 700px) {
    .responsive5 {
        width: 50%;
        margin: 6px 0;
        padding: 0 6px;
        display: grid;
        width: 20%;
    }
}

@media only screen and (max-width: 1200px) {
    .responsive5 {
        width: 50%;
        margin: 6px 0;
        padding: 0 6px;
        display: grid;
        width: 20%;
    }
}

@media only screen and (max-width: 500px) {
    .responsive5 {
        width: 50%;
        margin: 6px 0;
        padding: 0 6px;
        display: grid;
        width: 25%;
    }
}
/*  FOOTER   */

.icon-barfooter {
    width: 100%;
    background-color: #ffffff;
    overflow: hidden;
    position: fixed;
    bottom: 0;
    font-size: 30px;
}

.icon-barfooter p {
    float: left;
    width: 20%;
    text-align: center;
    padding: 14px 12px;
    transition: all 0.3s ease;
    color: #143bbd;
    font-size: 30px;
    text-decoration: none;
}

.icon-barfooter p:hover {
    background-color: #f2f2f2;
    font-weight: bold;
}

.icon-barfooter a {
    float: left;
    width: 20%;
    text-align: center;
    padding: 14px 12px;
    transition: all 0.3s ease;
    color: #143bbd;
    font-size: 30px;
    text-decoration: none;
}

.icon-barfooter a:hover {
    background-color: #f2f2f2;
    font-weight: bold;
}

.activefooter {
    background-color: #ffffff;
    font-weight: bold;
    color: #002c49;
}

.background {
    background: linear-gradient(45deg, #0d277e 10%, #143bbd, #1c51ff 100%);
}

.responsive5 {
    padding: 0 6px;
    margin: 6px 0;
    float: left;
    width: 20%;
    display: grid;
}

@media only screen and (max-width: 700px) {
    .responsive5 {
        width: 50%;
        margin: 6px 0;
        padding: 0 6px;
        display: grid;
        width: 20%;
    }
}

@media only screen and (max-width: 1200px) {
    .responsive5 {
        width: 50%;
        margin: 6px 0;
        padding: 0 6px;
        display: grid;
        width: 20%;
    }
}

@media only screen and (max-width: 500px) {
    .responsive5 {
        width: 50%;
        /*  margin: 6px 0;*/
        margin: 6px 0;
        padding: 0 6px;
        display: grid;
        width: 25%;
    }
}

.img {
    max-width: 400px;
    width: 100%;
    height: auto;
    border-radius: 5px;
    transition: 0.3s;
    margin: 0 auto;
    vertical-align: middle;
}

a {
    text-decoration: none;
    color: inherit;
}

a:after {
    text-decoration: none;
    color: inherit;
}

a:link {
    text-decoration: none;
    color: inherit;
}

a:visited {
    text-decoration: none;
    color: inherit;
    font-weight: bold;
}

a:hover {
    text-decoration: none;
    color: inherit;
}
/* Preloder */

#preloder {
    position: fixed;
    width: 100%;
    height: 100%;
    top: 0;
    left: 0;
    z-index: 999999;
    justify-content: center;
    gap: 2rem;
    padding: 3rem;
    min-height: 80vh;
    background: linear-gradient(45deg, #0d277e 10%, #143bbd, #1c51ff 100%);
    align-items: center;
    text-align: center;
}

.loader {
    width: 40px;
    height: 40px;
    position: absolute;
    top: 50%;
    left: 50%;
    margin-top: -13px;
    margin-left: -13px;
    border-radius: 60px;
    animation: loader 0.8s linear infinite;
    -webkit-animation: loader 0.8s linear infinite;
}

@keyframes loader {
    0% {
        -webkit-transform: rotate(0deg);
        transform: rotate(0deg);
        border: 4px solid #f44336;
        border-left-color: transparent;
    }
    50% {
        -webkit-transform: rotate(180deg);
        transform: rotate(180deg);
        border: 4px solid #673ab7;
        border-left-color: transparent;
    }
    100% {
        -webkit-transform: rotate(360deg);
        transform: rotate(360deg);
        border: 4px solid #f44336;
        border-left-color: transparent;
    }
}

@-webkit-keyframes loader {
    0% {
        -webkit-transform: rotate(0deg);
        border: 4px solid #f44336;
        border-left-color: transparent;
    }
    50% {
        -webkit-transform: rotate(180deg);
        border: 4px solid #673ab7;
        border-left-color: transparent;
    }
    100% {
        -webkit-transform: rotate(360deg);
        border: 4px solid #f44336;
        border-left-color: transparent;
    }
}

.responsive {
    width: 100%;
    max-width: 400px;
    height: auto;
}