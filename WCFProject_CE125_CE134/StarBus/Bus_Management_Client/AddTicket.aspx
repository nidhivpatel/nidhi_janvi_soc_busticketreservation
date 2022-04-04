<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTicket.aspx.cs" Inherits="Bus_Management_Client.AddTicket" %>

<!DOCTYPE html>


<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl" crossorigin="anonymous">
      <style>
          .form-control {
              width : 25%;
          }

      </style>
    <title>Book Ticket</title>
  </head>
  <body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">StarBus</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
      <div class="navbar-nav">
        <a class="nav-link active" aria-current="page" href="HomePage.aspx">Home</a>
          <a class="nav-link" href="AddTicket.aspx">Book Ticket</a>
          <a class="nav-link" href="PrintTicket.aspx">Booking History</a>
        <a class="nav-link" href="About.aspx">About</a>
        
      </div>
    </div>
  </div>
</nav>
   
      <center>
          <h4>Book a Ticket!</h4>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Name:&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
        </p>
        <p>
            Phone no.:&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:TextBox ID="TextBox2" class="form-control" runat="server"></asp:TextBox>
        </p>
        <p>
            Email:&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:TextBox ID="TextBox9" class="form-control" runat="server"></asp:TextBox>
        </p>
        <p>
            Source:&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:TextBox ID="TextBox3" class="form-control" runat="server"></asp:TextBox>
        </p>
        <p>
            Destination:</p>
        <asp:TextBox ID="TextBox4" class="form-control" runat="server"></asp:TextBox>
        <br />
        <br />
        Departure Time:<p>
            <asp:TextBox ID="TextBox5" class="form-control" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
        </p>
        Arrival Time:<br />
        <br />
        <asp:TextBox ID="TextBox6" class="form-control" runat="server" TextMode="DateTimeLocal" ></asp:TextBox>
        <br />
        <br />
        Total Seat:<br />
        <p>
            <asp:TextBox class="form-control" ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        <p>
         Seat Numbers :</p>
        <asp:TextBox class="form-control" ID="TextBox8" runat="server" ></asp:TextBox>
        <p>
            Amount:&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:TextBox class="form-control" ID="TextBox10" runat="server"></asp:TextBox>
        </p>
    
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
        </p>
       </form>
          </center>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js" integrity="sha384-b5kHyXgcpbZJO/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9FOnJ0" crossorigin="anonymous"></script>

   
  </body>
</html>