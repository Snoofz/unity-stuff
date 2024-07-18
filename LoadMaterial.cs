class MaterialManager {
  private Material LoadMaterial(string path)
      {
          if (File.Exists(path))
          {
              string materialName = File.ReadAllText(path);
              return new Material(materialName);
          }
          else
          {
              throw new FileNotFoundException($"The material file at {path} could not be found.");
          }
      }
}
