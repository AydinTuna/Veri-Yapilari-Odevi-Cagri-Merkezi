using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Çağrı_Merkezi_Ödevi
{
    public class BireyselMusteriLinkedList
    {
        Node head;

        public BireyselMusteriLinkedList()
        {
            head = null;
        }

        // Başa Ekleme
        public void basaEkle(int data)
        {
            Node eleman = new Node(data);

            if (head == null)
            {
                head = eleman;
            }
            else
            {
                eleman.next = head;
                head = eleman;
            }
        }

        // Baştan Sil
        public void bastanSil()
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş");
            }
            else
            {
                head = head.next;
                Console.WriteLine("Baştan eleman silindi");
            }
        }

        // Sondan Sil
        public void sondanSil()
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş");
            }
            else
            {
                Node temp = head;
                Node temp2 = null;
                while (temp.next != null)
                {
                    temp2 = temp;
                    temp = temp.next;
                }
                temp2.next = null;
                Console.WriteLine("Sondaki eleman silindi");
            }
        }

        // Aradan Sil
        public void aradanSil(int index)
        {
            bool sonuc = false;

            if (head == null)
            {
                sonuc = true;
                Console.WriteLine("Liste boş");
            }

            else if (head.next == null && index == 0)
            {
                head = null;
                Console.WriteLine("Listede kalan son eleman da silindi.");
                sonuc = true;
            }
            else if (head.next != null && index == 0)
            {
                bastanSil();
                Console.WriteLine("Eleman silindi");
                sonuc = true;
            }

            else
            {
                int i = 0;
                Node temp = head;
                Node temp2 = temp;
                while (temp.next != null)
                {
                    if (i == index)
                    {
                        sonuc = true;
                        temp2.next = temp.next;
                        Console.WriteLine("Aradan eleman silindi");
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
                if (i == index)
                {
                    sonuc = true;
                    temp2.next = null;
                    Console.WriteLine("Aradan eleman silindi");
                    i++;
                }
            }
            if (sonuc == false)
            {
                Console.WriteLine("Hatalı index seçimi yaptınız");
            }
        }

        // Yazdırma
        string mesaj;
        public string yazdir()
        {
            mesaj = "";
            
            Node temp = head;
            while (temp.next != null)
            {
                mesaj += temp.data + " -> ";
                temp = temp.next;
            }
            return mesaj;
        }

        // Sırada Arama
        public string SiradaArama(int arananEleman)
        {
            int i = 0;
            Node temp = head;
            while (temp != null)
            {
                i++;
                if (temp.data == arananEleman) break;
                temp = temp.next;
            }
            return i + ". sıradasınız.";
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
