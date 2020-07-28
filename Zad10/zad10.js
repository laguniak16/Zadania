var x =[18,3,30,22,11,60];
var number = 0;
fixage(x);
function fixage(x)
{
  for (i = 0; i < x.length; i++) {  
  
  		if(x[i] >= 18 && x[i] <= 60)
    	{	
        	number++;
        	if(i==x.length-1)
    			document.write(x[i]);
            else
                {
                document.write(x[i]+',');
                }
 		}      
  }
  if (number ==0)
  document.write("NA");
}
