using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreshFruit.Contrroller
{
    class BucketController
    {
        private BucketController bucket;
        private BucketEventListener eventListener;
        private int itemPosition;
        private Bucket keranjangBuah;
        private MainWindow mainWindow;

        public BucketController(BucketController bucket, BucketEventListener eventListener)
        {
            this.bucket = bucket;
            this.eventListener = eventListener;
        }

        public BucketController(Bucket keranjangBuah, MainWindow mainWindow)
        {
            this.keranjangBuah = keranjangBuah;
            this.mainWindow = mainWindow;
        }

        public void addFruit(Fruit fruit)
        {
            if (bucketIsOverload())
            {
                eventListener.onFailed("Ops, keranjang penuh");
            }
            else
            {
                this.bucket.insert(fruit);
                eventListener.onSucceed("yey berhsail ditambahakan");
            }  
        }

        private void insert(Fruit fruit)
        {
            throw new NotImplementedException();
        }

        public bool bucketIsOverload()
        {
            return bucket.countItems() >= bucket.getCapacity();
        }

        private int getCapacity()
        {
            throw new NotImplementedException();
        }

        public void removeFruit(Fruit fruit)
        {
            for (int itemPositon =0; itemPositon < bucket.countItems(); itemPosition++)
            {
                if (bucket.findAll().ElementAt(itemPosition).getName() == fruit.name)
                {
                    bucket.removeFruit(itemPosition);
                    eventListener.onSucceed("yeah, berhasil dihapus gaes");
                }
            }
        }

        private int countItems()
        {
            throw new NotImplementedException();
        }

        private void removeFruit(int itemPosition)
        {
            throw new NotImplementedException();
        }

        public List<Fruit> findAll()
        {
            return this.bucket.findAll();
        }
    }
}
