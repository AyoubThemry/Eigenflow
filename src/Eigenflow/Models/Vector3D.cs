namespace Eigenflow.Models;
 
internal class Vector3D : Vector
{
 public Vector3D(double[] orderedCordinates) : base(orderedCordinates, 3)
    {
        // no additional steps i can think of 
    }
 public Vector3D crossProduct(Vector3D tobeCrossProducted)
    {
        if (tobeCrossProducted.Dimensions != this.Dimensions)
        {
            throw new ArgumentException("Dimensions Do not match", nameof(Dimensions));
        }
        
       double x = (this.Coordinates[1]*tobeCrossProducted.Coordinates[2] - this.Coordinates[2]*tobeCrossProducted.Coordinates[1]);
       double y  = (this.Coordinates[2]*tobeCrossProducted.Coordinates[0] - this.Coordinates[0]*tobeCrossProducted.Coordinates[2]);
       double z = (this.Coordinates[0]*tobeCrossProducted.Coordinates[1] - this.Coordinates[1]*tobeCrossProducted.Coordinates[0]);

       
        return new Vector3D(new double[] { x, y, z });
    }

}