namespace Eigenflow.Models;

public class Matrix 
{
public double[][] Coordinates { get; set; } = Array.Empty<double[]>();
public int Rows {get;}
public int Columns {get;}
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