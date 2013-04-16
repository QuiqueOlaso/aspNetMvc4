Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Modifique esta plantilla para poner en marcha su aplicación ASP.NET MVC."

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Página de descripción de la aplicación."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Página de contacto."

        Return View()
    End Function
End Class
