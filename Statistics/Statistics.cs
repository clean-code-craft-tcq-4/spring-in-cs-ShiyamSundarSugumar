using System;
using System.Collections.Generic;

namespace Statistics.Test
{
double sum = 0.0,average=0.0, min=0.0, max=0.0;
            public object CalculateStatistics(List<float> numbers)
            {
            //Implement statistics here

               for (int i=0; i<numbers.Count; i++)
                {
                    if(i==0)
                    {
                        min = max = numbers[i];

                    }
                    if (max < numbers[i])
                    {
                        max = numbers[i];
                    }

                    if (min > numbers[i])
                    {
                        min = numbers[i];
                    }

                    sum += numbers[i];

                }


                average = sum / numbers.Count;

            
                return numbers;
                
            }
    
}
                
          
