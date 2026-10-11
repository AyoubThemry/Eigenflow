namespace Eigenflow.Models;

public class Matrix 
{
public double[][] Coordinates { get; set; } = Array.Empty<double[]>();
public int Rows {get;}
public int Columns {get;}
public Matrix(double[][] coordinates , int rows , int columns)
    {
        ArgumentNullException.ThrowIfNull(coordinates);
        if (Coordinates.Length != rows)
        {
            throw new ArgumentException();
        }
        for (int i = 0; i < rows ; i += 1)
        {
             if(Coordinates[i] is null || Coordinates[i].Length!= columns )
                {
                   throw new ArgumentException();
                }
        }
        this.Coordinates=coordinates;
        this.Rows = rows;
        this.Columns=columns;
    }
public Matrix ScalarProduct(double y)
{

    throw new NotImplementedException();
}
public Matrix Transpose()
{
    throw new NotImplementedException();
}

public Matrix Inverse()
{
    throw new NotImplementedException();
}

public double Determinant()
{
    throw new NotImplementedException();
}

public double Trace()
{
    throw new NotImplementedException();
}

public double[] EigenValues()
{
    throw new NotImplementedException();
}

public Vector[] EigenVectors()
{
    throw new NotImplementedException();
}
}