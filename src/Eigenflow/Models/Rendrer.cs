using System.Security.Cryptography.X509Certificates;

namespace Eigenflow.Models;

public interface IRendrer
{
    public void Render(Matrix toBeRendererd);
    public void Render(Vector toBeRendererd);
}