using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NE21_292T26_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai bao cac bien se duoc su dung trong cac bai tap ve mang
            int i, j, count, n, k, l, temp;

            Console.Write("Nhap vao so luong phan tu n = ");
            n = int.Parse(Console.ReadLine());

            
            int[] arr = new int[n]; // mang de luu du lieu nguoi dung
            int[] dup = new int[n]; // mang de luu phan tu giong nhau
            int[] evenArr = new int[n]; // mang de luu so chan
            int[] oddArr = new int[n]; // mang de luu so le

            /* Nhap mang voi n phan tu */
            for (i = 0; i < n; i++)
            {
                Console.Write("Nhap vap gia tri cho phan tu thu {0} = ", i);
                arr[i] = int.Parse(Console.ReadLine());
                dup[i] = -1;
            }

            /* 1. Đọc và in các phần tử trong mảng vừa nhập */
            Console.WriteLine("1. Mang vua nhap la :");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");         
            }

            /* 2. In mảng dữ liệu trên theo chiều đảo ngược */       
            Console.WriteLine();
            Console.WriteLine("2. Mang du lieu tren theo chieu dao nguoc la :");
            for (i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + "\t");
            }

            /* 3. Tìm số phần tử giống nhau trong mảng và hiển thị số lượng giống nhau ra màn hình. */
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                count = 1; // counter cua mang
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        dup[j] = 0;
                    }                 
                }
                if (dup[i] != 0)
                {
                    dup[i] = count;
                }
            }

            Console.WriteLine("3. Phan tu giong nhau gom :");
            for (i = 0; i < n; i++)
            {
                if (dup[i] > 1)
                {
                    Console.WriteLine("Phan tu " + arr[i] + " xuat hien " + dup[i] + " lan" );
                }
            }

            /* 4. In các phần tử duy nhất trong mảng. */
            // Dua tren viec su dung vong lap o bai 3, ta co the truy xuat cac phan tu duy nhat trong mang.
            Console.WriteLine("4. Cac phan tu duy nhat trong mang gom :");
            for (i = 0; i < n; i++)
            {
                if (dup[i] == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            /* 5. Chia mảng dữ liệu ban đầu thành mảng chẵn và mảng lẽ. */
            k = 0; // counter cua mang so chan
            l = 0; // counter cua mang so le

            for ( i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[k] = arr[i];
                    k++;
                } 
                else
                {
                    oddArr[l] = arr[i];
                    l++;
                }
            }

            // Mang so chan
            Console.WriteLine();
            Console.WriteLine("5.1. Mang so chan gom cac phan tu :");
            for (i = 0; i < k; i++)
            {
                Console.Write(evenArr[i] + " ");
            }

            // Mang so le:
            Console.WriteLine();
            Console.WriteLine("5.2. Mang so le gom cac phan tu :");
            for (i = 0; i < l; i++)
            {
                Console.Write(oddArr[i] + " ");
            }


            /* 6. Sắp xếp mảng theo thứ tự giảm dần. */
            temp = 0;

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("6. Mang sap xep theo thu tu giam dan :");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }


            /* 7. Tìm kiếm phần tử lớn thứ hai trong mảng dữ liệu ban đầu. */
            // Gia su tai su dung ket qua cua bai tap 6 - mang da duoc sap xep theo thu tu giam dan
            Console.WriteLine();
            Console.WriteLine("7. Phan tu lon thu hai trong mang = {0}", arr[1]);
               
            Console.ReadKey();
        }
    }
}
