using System.Security.Cryptography.X509Certificates;

namespace Eigenflow.Models;

public interface Rendrer
{
    public void render(Matrix toBeRendererd);
    public void render(Vector toBeRendererd);
}