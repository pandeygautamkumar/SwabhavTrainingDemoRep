<h1>Auth  Classic ASP Page</h1>
<body>
    Welcome
    <%
        For i = 1 To 5
            response.write("<h1>This is rendered from server side.</h1>")
        Next
    %>
</body>