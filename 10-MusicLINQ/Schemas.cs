using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MusicLINQ {

  public class Group {
    public int Id;
    public string GroupName;
    public List<Artist> Members;
    public Group() {
      Members = new List<Artist>();
    }
  }

  public class Artist {
    public string ArtistName;
    public string RealName;
    public int Age;
    public string Hometown;
    public int GroupId;
    public Group Group;
  }

  public class JsonToFile<T> {
    public static List<T> ReadJson() {
      string filename = $"10-MusicLINQ/{typeof(T).Name}.json";
      using (StreamReader file = File.OpenText(filename)) {
        JsonSerializer serializer = new JsonSerializer();
        return (List<T>)serializer.Deserialize(file, typeof(List<T>));
      }
    }
  }

}