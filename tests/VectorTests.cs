using Eigenflow.Models;
namespace tests;

public class VectorTests
{
    [Fact]
    public void constructor_WhenDimensionLessThanCoordinatesLength_ThrowsIllegalArgumentException()
    {
     
         Assert.Throws<ArgumentException>(()=> new Vector([5, 4, 3], 2));
        
    }
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
        Assert.Equal(-2, v2.Coordinates[0]);
        Assert.Equal(0, v2.Coordinates[1]);
        Assert.Equal(1, v2.Coordinates[2]);
        
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
            Vector v1 = new Vector([5, 4, 3], 3);
          
        // When + Then ( Assert + Addition  )
          Assert.Throws<ArgumentNullException>(()=>v1.Add(null!));
    }
        [Fact]
    public void Subtract_TwoValidVectors_ReturnsCorrectVector()
    {
       
        Vector v1 = new Vector([5, 4, 3], 3);
        Vector v2 = new Vector([-2 , 0 , 1],3);


        Vector v3 = v1.Subtract(v2);


        Assert.Equal(3,v3.Dimensions);
        Assert.Equal(7,v3.Coordinates[0]);
        Assert.Equal(4,v3.Coordinates[1]);
        Assert.Equal(2,v3.Coordinates[2]);
        Assert.False(v1 == v2);
        Assert.Equal(5, v1.Coordinates[0]);
        Assert.Equal(4, v1.Coordinates[1]);
        Assert.Equal(3, v1.Coordinates[2]);
        Assert.Equal(-2, v2.Coordinates[0]);
        Assert.Equal(0, v2.Coordinates[1]);
        Assert.Equal(1, v2.Coordinates[2]);

        
    }
    [Fact]
    public void Subtract_TwoVectorsWithDifferentDimensions_ThrowsException()
    {
       /* 2 Vectors One is 3 Dimensional and the other is 2 Dimensional throws an exception */
       Vector v1 = new Vector([1, 2, 3], 3);
       Vector v2 = new Vector([1, 2], 2);

       Assert.Throws<ArgumentException>(() => v1.Subtract(v2));

    }
    /* adding two vectors with one of them being null*/
    [Fact]
    public void Subtract_TwoVectorsWithOneOfThemNulled()
    {
        // Given
            Vector v1 = new Vector([5, 4, 3], 3);
          
        // When + Then ( Assert + Addition  )
           Assert.Throws<ArgumentNullException>(()=>v1.Subtract(null!));
    }
    [Fact]
    public void Scalar_TwoVectorsWithDifferentDimensions_ThrowsException()
    {
        // Given 
            Vector v1 = new Vector([1, 2, 3], 3);
            Vector v2 = new Vector([1, 2], 2);

        // When + Then
            Assert.Throws<ArgumentException>(()=> v1.ScalarProduct(v2));
    }
    [Fact]   
    public void Scalar_TwoVectorsWithOneOfThemNulled_ThrowsException()
    {
        // Given
            Vector v1 = new Vector([5, 4, 3], 3);
          
        // When + Then ( Assert + Addition  )
           Assert.Throws<ArgumentNullException>(()=>v1.ScalarProduct(null!));
    }
    [Fact]
    public void Scalar_TwoValidVectors_ReturnsCorrectDouble()
    {
        // Given
            Vector v1 = new Vector([5, 4, 3], 3);
            Vector v2 = new Vector([3, 0, 1.3], 3);
          
        // When 
            double result =v1.ScalarProduct(v2);

        // Then
        Assert.Equal(18.9,result);
    }

}
