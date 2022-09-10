using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [Serializable]
        class SerializClass
        {
            static public void Serializing(object obj)//Код для сериализации бллалалалаа
            {
                BinaryFormatter former = new BinaryFormatter();
                using (FileStream fs = new FileStream(obj + ".dat", FileMode.OpenOrCreate))
                {
                    former.Serialize(fs, obj);
                }
            }

            static public object Deserializing(string name)//Код для десериализации
            {
                BinaryFormatter former = new BinaryFormatter();
                using (FileStream fs = new FileStream(name + ".dat", FileMode.OpenOrCreate))
                {
                    return former.Deserialize(fs);
                }            
            }
        }

        [Serializable]
        class cat//Код класса cat
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Breed { get; set; }
            public string Color { get; set; }       
            public cat(string name, int age, string breed, string color)
            {
                Name = name;
                Age = age;
                Breed = breed;
                Color = color;
            }
        }

        [Serializable]
        class dog//Код класса dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Breed { get; set; }
            public string Color { get; set; }
            public dog(string name, int age, string breed, string color)
            {
                Name = name;
                Age = age;
                Breed = breed;
                Color = color;
              
            }
        }

        [Serializable]
        class bird //Код класса bird
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Breed { get; set; }
            public string Color { get; set; }          
            public bird(string name, int age, string breed, string color)
            {
                Name = name;
                Age = age;
                Breed = breed;
                Color = color;
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cat c = new cat("Musya", 6, "mongrel", "black");
            dog d = new dog("Lord", 8, "american cocker spaniel", "red");
            bird b = new bird("Rome", 2, "wavy popo", "blue");
            SerializClass.Serializing(c);
            SerializClass.Serializing(d);
            SerializClass.Serializing(b);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            cat nc = (cat)SerializClass.Deserializing("lab3.Form1+cat");
            dog nd = (dog)SerializClass.Deserializing("lab3.Form1+dog");
            bird nb = (bird)SerializClass.Deserializing("lab3.Form1+bird"); 
            label1.Text = nc.Name + "," + " "+ nc.Age + "," + " " + nc.Breed + "," + " " + nc.Color ;
            label2.Text = nd.Name + "," + " " + nd.Age + "," + " " + nd.Breed + "," + " " + nd.Color ;
            label3.Text = nb.Name + "," + " " + nb.Age + "," + " " + nb.Breed + "," + " " + nb.Color ;

        }
    }
}
