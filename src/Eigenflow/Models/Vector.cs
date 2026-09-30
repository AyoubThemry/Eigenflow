using System;
using System.Runtime.CompilerServices; // Required for Array.Empty
namespace Eigenflow.Models;
internal class Vector
{
    public double[] Coordinates { get; set;} = Array.Empty<double>();   
    
    public int Dimensions => Coordinates.Length;
    
    public Vector(double[] orderedCordinates,int length)
    {
        if (orderedCordinates.Length != length)
        {
           throw new ArgumentException("Length does not match the provided coordinates.", nameof(length));
       
        }
        Coordinates = new double[length];
        for (int i = 0;i < length;i++)
        {
            Coordinates[i]=orderedCordinates[i]; 
        }
    }
 
    public Vector Add(Vector toBeAdded)
    {
        // bouncer pattern 
        // check code under this ?
     /*    if(this.Dimensions is null || toBeAdded.Dimensions is null)
        {
            throw new InvalidOperationException("Cannot add Vectors because Dimensions is null one of both Vectors is Null.");
        }  */
        if (toBeAdded.Dimensions != this.Dimensions)
        {
            throw new ArgumentException("Dimensions Do not match", nameof(Dimensions));
        }
        
        for(int i = 0; i < Dimensions; i++)
        {
            this.Coordinates[i]=this.Coordinates[i]+toBeAdded.Coordinates[i];
        }
        return this;
    }
    public Vector Subtract(Vector toBeSubtracted)
    {
        // bouncer pattern 
        // check code under this 
      /*  if(this.Dimensions is null || toBeSubtracted.Dimensions is null)
        {
            throw new InvalidOperationException("Cannot add Vectors because Dimensions is null one of both Vectors is Null.");
        }  */
        if (toBeSubtracted.Dimensions != this.Dimensions)
        {
            throw new ArgumentException("Dimensions Do not match", nameof(Dimensions));
        }
        for(int i = 0; i < Dimensions; i++)
        {
            this.Coordinates[i]=this.Coordinates[i]-toBeSubtracted.Coordinates[i];
        }
        return this;
    }
    public double ScalarProduct(Vector tobeScalarProducted)
    {
        // bouncer pattern 
        // check code under this 
      /*   if(this.Dimensions is null || tobeScalarProducted.Dimensions is null)
        {
            throw new InvalidOperationException("Cannot add Vectors because Dimensions is null one of both Vectors is Null.");
        }  */
        if (tobeScalarProducted.Dimensions != this.Dimensions)
        {
            throw new ArgumentException("Dimensions Do not match", nameof(Dimensions));
        }
        double sum = 0;
        for(int i = 0; i < Dimensions; i++)
        {
            sum+=this.Coordinates[i]*tobeScalarProducted.Coordinates[i];
        }
        return sum;
    }

        
    }


   