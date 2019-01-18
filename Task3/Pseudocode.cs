//setup
var totalbottles = 0
var numday = 0
var numberofbottles = 0
var isNumeric = false
var thecost = 0.10
var profit = 0

//input
do
{
daynum=daynum+1;
PUT("How many bottles did you collect on day " + numday + "   Type 0 to finish")
GET numberofbottles

totalbottles = totalbottles + numberofbottles           

}while (numberofbottles<>0)


//processing
profit = totalbottles * thecost


//output
PUT "You collected " + totalbottles + " for a total cost of " + profit

