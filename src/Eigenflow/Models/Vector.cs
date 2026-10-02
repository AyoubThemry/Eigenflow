using System;
using System.Runtime.CompilerServices;

namespace Eigenflow.Models;

internal class Vector
{
    public double[] Coordinates { get; set; } = Array.Empty<double>();   
    
    public int Dimensions => Coordinates.Length;
    
    public Vector(double[] orderedCordinates, int length)
    {
        if (orderedCordinates.Length != length)
        {
            throw new ArgumentException("Length does not match the provided coordinates.", nameof(length));
        }
        Coordinates = new double[length];
        for (int i = 0; i < length; i++)
        {
            Coordinates[i] = orderedCordinates[i]; 
        }
    }
 
    public Vector Add(Vector toBeAdded)
    {

        if (toBeAdded == null)
        {
            throw new ArgumentNullException(nameof(toBeAdded));
        }
        if (toBeAdded.Dimensions != this.Dimensions)
        {
            throw new ArgumentException("Dimensions do not match.", nameof(toBeAdded));
        }
        
        double[] newCoordinates = new double[this.Dimensions];
        for(int i = 0; i < this.Dimensions; i++)
        {
            newCoordinates[i] = this.Coordinates[i] + toBeAdded.Coordinates[i];
        }
        

        return new Vector(newCoordinates, this.Dimensions);
    }

    public Vector Subtract(Vector toBeSubtracted)
    {
        if (toBeSubtracted == null)
        {
            throw new ArgumentNullException(nameof(toBeSubtracted));
        }
        if (toBeSubtracted.Dimensions != this.Dimensions)
        {
            throw new ArgumentException("Dimensions do not match.", nameof(toBeSubtracted));
        }

        double[] newCoordinates = new double[this.Dimensions];
        for(int i = 0; i < this.Dimensions; i++)
        {
            newCoordinates[i] = this.Coordinates[i] - toBeSubtracted.Coordinates[i];
        }
        
    
        return new Vector(newCoordinates, this.Dimensions);
    }

    public double ScalarProduct(Vector tobeScalarProducted)
    {
        if (tobeScalarProducted == null)
        {
            throw new ArgumentNullException(nameof(tobeScalarProducted));
        }
        if (tobeScalarProducted.Dimensions != this.Dimensions)
        {
            throw new ArgumentException("Dimensions do not match.", nameof(tobeScalarProducted));
        }

        double sum = 0;
        for(int i = 0; i < this.Dimensions; i++)
        {
            sum += this.Coordinates[i] * tobeScalarProducted.Coordinates[i];
        }
        return sum; 
    }
}