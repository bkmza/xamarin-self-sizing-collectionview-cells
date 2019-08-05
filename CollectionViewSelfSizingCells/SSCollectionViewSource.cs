using System;
using Foundation;
using UIKit;

namespace CollectionViewSelfSizingCells
{
    public class SSCollectionViewSource : UICollectionViewSource
    {
        private string[] _items;

        public SSCollectionViewSource(UICollectionView collectionView)
        {
            _items = new[] {
                "Item 1: short text",
                "Item 2: a little bit longer text",
                "Item 3: a real long message about death and life"
            };
            collectionView.RegisterClassForCell(typeof(SSCollectionCell), SSCollectionCell.Key);
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = collectionView.DequeueReusableCell(SSCollectionCell.Key, indexPath) as SSCollectionCell;
            cell.SetTitle(_items[indexPath.Row]);
            return cell;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
            => _items.Length;
    }
}
