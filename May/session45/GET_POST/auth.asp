<h1>Auth Classic ASP Page</h1>

<body>
    Welcome
    <%
        For i=1 to 5
            response.write("<h1> this is rendered from the server side</h1>")
        Next
    %>
    <br>
    <h1>Showing Form Data</h1>
    <% 
        response.write(request.form("userName")) 
        response.write(request.form("userPassword")) 
    %>
</body>