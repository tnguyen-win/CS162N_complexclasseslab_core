using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomerProductClasses;

namespace CustomerProductListTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 40);
            //TestProductListConstructor();
            //TestProductListAdd();
            //TestProductListSaveAndFill();
            //TestProductListRemove();
            //TestProductEquals();
            //TestProductGetHashCode();
            //TestProductEqualityOperator();
            //TestProductInequalityOperator();
            TestProductListIndexer();

            Console.ReadLine();
        }

        static void TestProductListConstructor()
        {
            ProductList list = new ProductList();

            Console.WriteLine("Testing product list default constructor");
            Console.WriteLine("Count.  Expecting 0. " + list.Count);
            Console.WriteLine("ToString.  Expect an empty string. " + list.ToString());
            Console.WriteLine();
        }

        static void TestProductListAdd()
        {
            ProductList list = new ProductList();
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);
            Product p2 = new Product(2, "T200", "This is a test product 2", 200M, 20);

            Console.WriteLine("Testing product list add.");
            Console.WriteLine("BEFORE Count.  Expecting 0. " + list.Count);
            list.Add(p1);
            Console.WriteLine("AFTER Add Count.  Expecting 1. " + list.Count);
            Console.WriteLine("ToString.  Expect one product " + list.ToString());
            list += p2;
            Console.WriteLine("AFTER Second Add Count.  Expecting 2. " + list.Count);
            Console.WriteLine("ToString.  Expect two products " + list.ToString());
            Console.WriteLine();
        }

        static void TestProductListSaveAndFill()
        {
            ProductList list = new ProductList();
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);
            Product p2 = new Product(2, "T200", "This is a test product 2", 200M, 20);
            list.Add(p1);
            list += p2;
            list.Save();

            list = new ProductList();
            list.Fill();
            Console.WriteLine("Testing product list save and fill.");
            Console.WriteLine("After Fill Count.  Expecting 2. " + list.Count);
            Console.WriteLine("ToString.  Expect two products " + list.ToString());
            Console.WriteLine();
        }

        static void TestProductEquals()
        {
            // these 2 objects should be equal.  They reference the same object.
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);
            Product p1Reference = p1;
            // these 2 objects should be equal after overridding Equals.  The attribute values are all equal.
            Product p2 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing product equals.");
            Console.WriteLine("2 references to the same object.  Expecting true. " + p1.Equals(p1Reference));
            Console.WriteLine("2 object that have the same properties should be equal.  Expecting true. " + p1.Equals(p2));
            Console.WriteLine();

        }

        static void TestProductListRemove()
        {
            // test fails before I add equals to product
            ProductList list = new ProductList();
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            list.Fill();
            Console.WriteLine("Testing product list remove.");
            Console.WriteLine("Before remove Count.  Expecting 2. " + list.Count);
            Console.WriteLine("ToString.  Expect two products " + list.ToString());
            list.Remove(p1);
            Console.WriteLine("After remove Count.  Expecting 1. " + list.Count);
            Console.WriteLine("ToString.  Expect just product 2 " + list.ToString());
            Console.WriteLine();
        }

        static void TestProductGetHashCode()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);
            // these 2 objects should have the same hashcode.  The attribute values are all equal.
            Product p2 = new Product(1, "T100", "This is a test product", 100M, 10);
            // this one should have a unique hashcode
            Product p3 = new Product(3, "T300", "This is a test product 3", 300M, 30);

            Console.WriteLine("Testing product GetHashCode");
            Console.WriteLine("2 object that have the same properties should have the same hashcode.  Expecting true. " + (p1.GetHashCode() == p2.GetHashCode()));
            Console.WriteLine("2 object that have different properties should have different hashcodes.  Expecting false. " + (p1.GetHashCode() == p3.GetHashCode()));

            // this will fail before overriding GetHashCode
            HashSet<Product> set = new HashSet<Product>();
            set.Add(p1);
            set.Add(p3);
            Console.WriteLine("Testing product GetHashCode by using a hash set");
            Console.WriteLine("The hash set should be able to find an object with the same attributes.  Expecting true. " + set.Contains(p2));

            Console.WriteLine();
        }

        static void TestProductEqualityOperator()
        {
            // these 2 objects should be equal.  They reference the same object.
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);
            Product p1Reference = p1;
            // these 2 objects should be equal after overridding Equals.  The attribute values are all equal.
            Product p2 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing product ==");
            Console.WriteLine("2 references to the same object.  Expecting true. " + (p1 == p1Reference));
            Console.WriteLine("2 object that have the same properties should be equal.  Expecting true. " + (p1 == p2));
            Console.WriteLine();
        }

        static void TestProductInequalityOperator()
        {
            // these 2 objects should be equal after overridding Equals.  The attribute values are all equal.
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);
            Product p2 = new Product(1, "T100", "This is a test product", 100M, 10);
            // this one should not be equal
            Product p3 = new Product(3, "T300", "This is a test product 3", 300M, 30);

            Console.WriteLine("Testing product !=");
            Console.WriteLine("2 objects that have the same properties should be equal.  Expecting false. " + (p1 != p2));
            Console.WriteLine("2 objecst that have different properties should not be equal.  Expecting true. " + (p1 != p3));
            Console.WriteLine();
        }

        static void TestProductListIndexer()
        {
            // test fails before I add equals to product
            ProductList list = new ProductList();
            list.Fill();

            Console.WriteLine("Testing product list indexer");
            Console.WriteLine("Index 1.  Expecting first product in list to be T100 \n" + list[0]);
            Console.WriteLine("Index 'T200'.  Expecting product with code of T200 \n" + list["T200"]);
            Console.WriteLine();
        }
    }
}
