using Eigenflow.Models;
namespace tests;

public class Vector3DTests
{
    [Fact]
    public void Create_Vector_WithDimensionsDifferentThanThree_ThrowsException()
    {
     Assert.Throws<ArgumentException>(()=> new Vector3D([5, 4, 3 , 0]));
    }
    [Fact]
    public void Scalar_TwoOfVector3D_ReturnsVector3D()
    {
        // Given
         Vector3D v1 = new Vector3D([5, 4, 3]);
         Vector3D v2 = new Vector3D([1, 4, -1]);

        // When
        Vector3D v3 = v1.CrossProduct(v2);

        // Then
        Assert.Equal((4-20),v3.Coordinates[0]);
        Assert.Equal((3+5),v3.Coordinates[1]);
        Assert.Equal((20-4),v3.Coordinates[2]);
    }

}