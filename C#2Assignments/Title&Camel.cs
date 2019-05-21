using System;

namespace C_2Assignments
{
    class DemoTitleCamel
    {
        public void DemoTitle(){
                String str="this is demo prgoram.";
                string[] s5= str.Split(' '); 
                int le=s5.Length;
                
                for(int i=0;i<le;i++)
                {
                     if(i==0)
                {
                    s5[i]=s5[i].ToLower();              
                }

                else
                {
                    char[] output=s5[i].ToCharArray();
                        for(int j=0;j<s5[i].Length;j++)
                        {
                            

                            if(j==0)
                            {
                                output[j]=char.ToUpper(output[j]);
                            }
                            else
                            {
                                output[j]=char.ToLower(output[j]);
                            }
                        
                            
                        }
                         s5[i]=new string(output);

                }
            }
             string camelString = string.Join("", s5);
             Console.WriteLine("Camel String is:"+camelString);
                  
                }

                public void TestDemoTitle(){
                    String str="this is demo prgoram.";
                string[] s5= str.Split(' '); 
                int le=s5.Length;
                
                for(int i=0;i<le;i++)
                {
                    
                    char[] output=s5[i].ToCharArray();
                        for(int j=0;j<s5[i].Length;j++)
                        {
                            

                            if(j==0)
                            {
                                output[j]=char.ToUpper(output[j]);
                            }
                            else
                            {
                                output[j]=char.ToLower(output[j]);
                            }
                        
                            
                        }
                         s5[i]=new string(output);

                }
            
             string titleString = string.Join("", s5);
             Console.WriteLine("Title String is:"+titleString);


                }
             

        }
    }

