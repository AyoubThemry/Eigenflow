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
      // instead of a return not Implemented Exception
      throw new NotImplementedException();
    }

}