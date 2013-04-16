Namespace aspNetMvc4
    Public Class HelloWorldController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /HelloWorld

        '**************** INDEX *****************

        'Function Index() 'As ActionResult
        ''http://www.asp.net/mvc/tutorials/mvc-4/getting-started-with-aspnet-mvc4/adding-a-controller
        ''forma más sencilla de hacerlo
        ''comentando as actionresult en la definición de función
        ''se visualiza con http://localhost:1038/HelloWorld
        ''o ''se visualiza con http://localhost:1038/HelloWorld/Index
        'Return "This is my <b>Default</b> Action..."
        'End Function

        Function Index() As ActionResult
            ViewData("Message") = "This is my <b>Default</b> Action..."
            Return View()
        End Function


        '**************** WELCOME *****************

        'Function Welcome() 'As ActionResult
        'http://www.asp.net/mvc/tutorials/mvc-4/getting-started-with-aspnet-mvc4/adding-a-controller
        ''forma más sencilla de hacerlo
        ''comentando as actionresult en la definición de función
        ''se visualiza con http://localhost:1038/HelloWorld/Welcome
        'Return "This is the Welcome Action Method..."
        'End Function

        Function Welcome(ByVal name As String, ByVal numTimes As String) As ActionResult
            Dim theTextReturn As String
            theTextReturn = HttpUtility.HtmlEncode("This is the Welcome Action Method...: hello " + name + ", NumTimes is: " + numTimes)
            ViewData("Message") = theTextReturn
            Return View()
        End Function

    End Class
End Namespace