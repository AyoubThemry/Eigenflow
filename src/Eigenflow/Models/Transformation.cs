using System.Runtime.CompilerServices;

namespace Eigenflow.Models;
public class Transformation
{
    Matrix TransformationMatrix {get;set;}
    public Transformation(Matrix x)
    {
        this.TransformationMatrix = x;
    }
    public Vector Transform(Vector toBeTransformed)
    {
        // This return is just boilerplate to be removed when writing logic
        return toBeTransformed;
    }

}