# SignalR-Web-API-Core-CORS-Example
Example of using SignalR 2 with ASPNET Web API Core with SignalR clients in different domains.

The web api core runs at port 35679 and hosts the SignalR and JQuery scripts.

The client is a Vue JS component in a HTML page. Multiple copies of the client can be hosted at different ports or domain to test the CORS SignalR connection.

1. Configure Web API project to support CORS and Signalr. Good reference: https://cmatskas.com/signalr-cross-domain-with-cors/

2. Setup Signal R. Good reference: https://www.codeproject.com/Articles/1115941/ASP-NET-Core-Building-a-Real-Time-Online-Poll-Syst

3. Configure Web API to serve static file - we need jquery.signalR-2.2.2.js and jquery.js to be hosted by our server, they need to be under wwwroot.

4. In the Javascript client, include the script tags to point back to our server:

<script src="http://localhost:35679/jquery.js" ></script>
       
<script src="http://localhost:35679/jquery.signalR-2.2.2.min.js"></script>
      
<script src="http://localhost:35679/signalr/hubs"></script>


5. In the client startup code, remember to point hub Url back to our server:
$.connection.hub.url = 'http://localhost:35679/signalr';
