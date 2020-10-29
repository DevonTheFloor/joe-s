@charset "UTF-8";
@font-face {
  font-family: 'airstreamregular';
  src: url("../police/Airstream-webfont.eot");
  src: url("../police/Airstream-webfont.eot?#iefix") format("embedded-opentype"), url("../police/Airstream-webfont.woff2") format("woff2"), url("../police/Airstream-webfont.woff") format("woff"), url("../police/Airstream-webfont.ttf") format("truetype"), url("../police/Airstream-webfont.svg#airstreamregular") format("svg");
  font-weight: normal;
  font-style: normal; }
@font-face {
  font-family: 'grutchshadedregular';
  src: url("../police/GrutchShaded-webfont.eot");
  src: url("../police/GrutchShaded-webfont.eot?#iefix") format("embedded-opentype"), url("../police/GrutchShaded-webfont.woff2") format("woff2"), url("../police/GrutchShaded-webfont.woff") format("woff"), url("../police/GrutchShaded-webfont.ttf") format("truetype"), url("../police/GrutchShaded-webfont.svg#grutchshadedregular") format("svg");
  font-weight: normal;
  font-style: normal; }
body {
  display: flex;
  flex-direction: column;
  justify-content: center;
  background-image: url("image/back/bkgrd2.png");
  background-repeat: no-repeat;
  background-attachment: fixed;
  background-size: cover; }

main {
  /*ici encadré transparent blanc*/
  background-color: #e8e7e3;
  opacity: 0.85;
  margin: 10%;
  margin-bottom: 5%;
  border: 0.5em ridge #5fc191;
  border-radius: 45px;
  box-shadow: 2px 2px 5px #a4ecf1; }

h1 {
  /* ========== ICI LA COULEUR DU TITRE ================= */
  text-align: center;
  color: #5fc191;
  font-family: 'airstreamregular';
  font-size: 6em;
  text-shadow: 2px 10px 10px #a4ecf1; }

h2 {
  border: 2px solid green;
  display: flex;
  margin-left: 20%;
  margin-right: 20%;
  justify-content: center;
  font-family: 'grutchshadedregular';
  text-shadow: 2px 2px 2px green; }

p {
  color: #5fc191;
  text-shadow: 2px 3px 3px #a4ecf1;
  text-align: center; }

#nomsite {
  text-align: center;
  font-size: 8em; }

ol {
  display: flex;
  flex-direction: row; }

#video {
  margin-left: 25%;
  display: flex;
  justify-content: center; }

li {
  list-style: none; }

#photo {
  border-radius: 45%;
  margin-top: 5%;
  width: 9%;
  height: 9%; }

.tel {
  display: none; }

a:hover {
  font-weight: bold;
  color: green; }

#galerie-menu {
  height: 300px;
  width: 850px;
  margin: 3em auto;
  border: solid;
  border-radius: 5px;
  box-shadow: 1px 1px 3px gray;
  text-align: right;
  position: relative;
  white-space: nowrap;
  overflow: hidden; }

#galerie-menu a, #galerie-menu:hover a:focus {
  display: inline-block;
  vertical-align: top;
  width: 30px;
  height: 300px;
  overflow: hidden;
  position: relative;
  z-index: 1;
  box-shadow: 0 0 15px white;
  transition: 2s;
  transition-timing-function: cubic-bezier(0, 0.01, 0, 1); }

#galerie-menu a:hover, #galerie-menu a:focus {
  width: 400px;
  transition: 2s;
  transition-timing-function: cubic-bezier(0, 0.01, 0, 1); }

#galerie-menu a:first-child, #galerie-menu:hover a:focus:first-child {
  width: 400px;
  position: absolute;
  top: 0;
  left: 0;
  z-index: 0; }

#galerie-menu a:before {
  content: attr(title);
  text-align: center;
  height: 30px;
  width: 250px;
  position: absolute;
  bottom: 0;
  left: 0;
  padding-right: 100px;
  font-size: 30px;
  color: white;
  border: 1px solid gray;
  box-shadow: 0 0 15px white;
  background: rgba(0, 0, 0, 0.3);
  transform: rotate(-90deg);
  transform-origin: 17px;
  line-height: 22px; }

footer {
  border: 2px solid yellow;
  display: flex;
  justify-content: center; }

/*--------------------------- MEDIA ----------------------------------*/
@media screen and (max-width: 1000px) {
  #galerie-menu {
    border: solid;
    border-radius: 0px;
    box-shadow: 1px 1px 3px gray;
    text-align: center;
    transform: rotate(90deg); }

  #photo {
    width: 6%;
    height: 6%; }

  main {
    margin: 6%; }

  #nomsite {
    font-size: 4em; }

  h1 {
    font-size: 3em;
    text-align: center; } }
/*======================= SMARTPHONE ================================*/
@media screen and (max-width: 600px) {
  body {
    background-image: url("image/back/backSmart.jpg");
    background-repeat: no-repeat;
    background-attachment: fixed;
    background-size: 100%; }

  /*.menutel{
  	display:contents;
  	font-size:bold;
  	text-align:center;}*/
  #video {
    display: none; }

  /*footer{display:none;
  	display:flex;
  	justify-content:center;*/ }
ul {
  justify-content: space-around;
  display: flex;
  flex-direction: column; }

.navtel {
  justify-content: space-around;
  display: flex;
  flex-direction: rew; }

.titre {
  font-size: 2em; }

header {
  display: none; }

#bloc21 {
  display: none; }

#photoSmart {
  width: 4%;
  height: 4%; }

/* rest 
#galerie-menu {
	border:solid;
	border-radius:0px;
	box-shadow:1px 1px 3px gray;
	text-align:center;
	height:200px;
	width:480px;
	
	transform:rotate(90deg);}

#galerie-menu a:hover , #galerie-menu a:focus 
{
	display:none;

}

#galerie-menu a:before 
{
	content:attr(title);
	text-align:center;
	height:8%;
	width:200px;
	/*position:absolute;
	bottom:0;
	left:0;*/
	/*padding-right:100px;
	font-size:18px;
	color:green;
	border:1px solid green;
	/*box-shadow:0 0 15px white;
	background:rgba(0,0,0,0.3);
	/*transform:rotate(-90deg);
	transform-origin:17px;
	line-height:22px;

*/

/*# sourceMappingURL=style.cs.map */
