using System;

namespace C_2Assignments
{
    class DemoDistinctStr
    {
        public void Demo(){
                    
        String demostr="this is my demo project and this find distinct string";
        String s2= demostr.Trim();
         string[] splittedstr= s2.Split(' '); 
         int len=splittedstr.Length; 
         int count=0;;
           for(int i=0;i<=len-1;i++)  
           {  
               for(int j=0;j<=len-1;j++){
                   if(splittedstr[i]==splittedstr[j]){
                       count++;
                   }
               }
            
           }  
          
           int similarcount=0;
           //int t;
           for(int i=0;i<=len-1;i++)  
           {  
               for(int j=i;j<=len-1;j++){
                   if(i!=j)
                   {
                   if(splittedstr[i].Equals(splittedstr[j])){
                       similarcount++;
                   }
                   }
               }
            
           }
             
           Console.WriteLine("Total distinct words="+(len-similarcount));  



    }
       
    }

}