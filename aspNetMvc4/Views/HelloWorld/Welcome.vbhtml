@Code
    'lo comentamos porque lo pasamos al HomeController
    'ViewData("Title") = "Página principal"
End Code

@section featured
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>@ViewData("Message")</h1>
            </hgroup>            
        </div>
    </section>
End Section

