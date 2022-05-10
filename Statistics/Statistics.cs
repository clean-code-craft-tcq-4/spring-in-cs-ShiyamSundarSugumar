using System;
using System.Collections.Generic;
using System.Linq

namespace Statistics.Test
{
            public class StatsComputer
            {
                        public double sum = 0.0,average=0.0, min=0.0, max=0.0;
                        public object CalculateStatistics(List<double> numbers)
                        {
                        //Implement statistics here
                           
                            // If Empty list arrived
                           if (numbers == null )
                           {
                                       sum = average = min = max = Double.NaN;
                           }
                           else
                           {
                                       
                            
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
                            
                           }
                           return numbers;
                        }
                
            }
public class StatsAlerter

    {
        private IAlerter[] alerters;
        private float maxthreshold;

        public StatsAlerter(float maxthreshold,IAlerter[] alerters)
        {
            this.alerters = alerters;
            this.maxthreshold = maxthreshold;
        }

        public void checkAndAlert(List <float> values)
        {
            if(values.Max()>maxthreshold)
            {
                alerters[0].AlertSet();
                alerters[1].AlertSet();

            }
        }

    }


    public interface IAlerter
    {
         void AlertSet();
    }


    public class EmailAlert : IAlerter
    {
        public bool emailSent;

        public void AlertSet()
        {
            emailSent = true;
        }
    }


    public class LEDAlert : IAlerter
    {
        public bool ledGlows;
        
        public void AlertSet()
        {
            ledGlows = true;
        }
    }
            
            
            
    
}
                
          
