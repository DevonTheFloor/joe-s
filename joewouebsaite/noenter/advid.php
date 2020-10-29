<?php
if (isset($_POST)){
   try{
        $bdd = new PDO('mysql:host=sql.free.fr;dbname=joenibrocoli;charset=utf8','joenibrocoli@free.fr','Mot2PasseBr@c@li');
        $bdd->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        }
        catch(Exception $e){
          die('Erreur : '.$e->getMessage());
          }
     var_dump($_POST['h1']);
     echo'<pre>';
     var_dump($_POST);
    echo'</pre>';
	echo'<pre>';
	print_r($_POST);
echo'</pre>';
     $req = $bdd->prepare('INSERT INTO tutoyo (h1, h2,h3, sschapo,descrip,link) VALUES(:h1, :h2,:h3, :sschapo, :descrip,:link)');
     $req->execute(array(
	   'h1' => $_POST['h1'],
	   'h2'=> $_POST['h2'],
	   'h3'=> $_POST['h3'],
	   'sschapo'=> $_POST['sschapo'],
	   'descrip' => $_POST['descrip'],
	    'link' => $_POST['link']));
}
header('location:form.html');


