
<!DOCTYPE html>
<html>
	<head>
		<title>ica04 - Form Submit Tester</title>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style>
@import url(//fonts.googleapis.com/css?family=Comfortaa|Raleway|Source+Code+Pro&effect=3d);
body{
  font-family: Raleway, Tahoma, sans-serif;
  font-size: x-large;
}
#main {
  display:grid;
  grid-gap : 20px 0px;
  grid-template-columns: 1fr 3fr 1fr;
}
div.jumbotron, div.footer {
  grid-column : 1 / 4;
}
div.jumbotron {
  font-family: Comfortaa, sans-serif;
  background-color: maroon;
  color: #cccccc;
}
div.footer {
  background-color: maroon;
  color:white;
	border-radius: 20px;
}
div.container {
  grid-column : 2 / 3;
}
.mono {
  font-family: "Source Code Pro", Consolas, monospace;
}
.text-center {
  text-align: center;
}
table {
  width : 100%;
}
th, td {
  text-align: left;
  padding-right: 50px;
}
 tr:nth-child(odd) {
  background-color:#f59444;
  color:black;
}
tr:nth-child(even) {
  background-color:lightgreen;
  color:black;
}
    </style>
	</head>
	<body>
    <div id="main">
    <div class="jumbotron text-center">
			<h1 class="font-effect-3d">Exam 2 Submit Test</h1>
    </div>
		<div class="container">
      <?php

        

        // define variables and set to empty values
        $fName = $lName = $foodType = $foodCount = $foodCost = "";

        if ($_SERVER["REQUEST_METHOD"] == "GET")
        {
        
          
        $uName = $_GET["uname"];
        $foodType = $_GET["food"];
        $foodCount = $_GET["fooditemcount"];
        $foodCost = $_GET["totalCost"];

        if($uName!="")
        {
          echo("<h3 style='color:maroon;'>Form Submitted Successfully - Congratulations!! <h3>");
        echo "
        <table>
        <tr>
          <th>First Name</th>
          <td>".$uName."</td>
        </tr>
       
        <tr>
          <th>Food Item Ordered</th>
          <td>".$foodType."</td>
        </tr>

        <tr>
        <th>Number of  ".$foodType."</th>
        <td>".$foodCount."</td>
        </tr>

        <tr>
        <th>Total Food Cost</th>
        <td>".$foodCost."</td>
        </tr>
        
        <tr>
        <th>Conditions accepted</th>
        <td> Yes </td>
        </tr>
        <tr>
        <th style='col-span:2;'>Thank you for your order! Wait for your turn</th>
        <td></td>
        </tr>
        </table>";
        }
        else{
          echo "<h2>No Get/Post data found in request!</h2>"; 
        }
        }
        
        
        ?>
  
    </div>
    <div class="footer text-center">
      CMPE 2000 - Lab Exam5 - Fall 2025<br/>
      <script>document.write('Last Modified:' + document.lastModified);</script>
    </div>
      </div>
	</body>
</html>



 