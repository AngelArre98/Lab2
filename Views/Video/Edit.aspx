﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Edit</title>
</head>
<body>
    
    <form action="/Video/Edit" method ="post">
    <fieldset>
    <legend>Editar Video</legend>

    <label for ="Idvideo">ID del Video</label>
    <input type ="text" name="Idvideo"/>

    <label for ="titulo">Titulo </label>
    <input type ="text" name="titulo" />

    <label for ="repro">Reproduccione</label>
    <input type="text" name="repro"/>

    <label for ="url">URL</label>
    <input type ="text" name="url"/> 

    <input type="submit" value="Editar" />
   
    </fieldset>
    </form>
</body>
</html>
