using Eigenflow.Models;
namespace tests;

public class VectorTests
{
    [Fact]
    public void Add_TwoValidVectors_ReturnsCorrectVector()
    {
       
        Vector v1 = new Vector([5, 4, 3], 3);
        Vector v2 = new Vector([-2 , 0 , 1],3);


        Vector v3 = v1.Add(v2);


        Assert.Equal(3,v3.Dimensions);
        Assert.Equal(3,v3.Coordinates[0]);
        Assert.Equal(4,v3.Coordinates[1]);
        Assert.Equal(4,v3.Coordinates[2]);
        Assert.False(v1 == v2);
        Assert.Equal(5, v1.Coordinates[0]);
        Assert.Equal(4, v1.Coordinates[1]);
        Assert.Equal(3, v1.Coordinates[2]);

        
    }
    [Fact]
    public void Add_TwoVectorsWithDifferentDimensions_ThrowsException()
    {
       /* 2 Vectors One is 3 Dimensional and the other is 2 Dimensional throws an exception */
       Vector v1 = new Vector([1, 2, 3], 3);
       Vector v2 = new Vector([1, 2], 2);

       Assert.Throws<ArgumentException>(() => v1.Add(v2));

    }
    /* adding two vectors with one of them being null*/
    [Fact]
    public void Add_TwoVectorsWithOneOfThemNulled()
    {
        // Given
    
        // When
    
        // Then
    }
}
