using System;
using Foundation;
using UIKit;

namespace CollectionViewSelfSizingCells
{
    public class SSHomeCollectionViewController : UICollectionViewController
    {
        private string[] _items => new[] {
                "Item 1: short text",
                "Item 2: a little bit longer text",
                "Item 3: a real long message about death and life",
                "Item 4: something about Jessica Jones",
                "Item 5: do you want a drink?",
                "Item 6: I'm tired.",
                "Item 7: Looks like this message will have width more than the screen width!",
                "Item 8: Couple more couples",
                "Item 9: Actually, it's just a monday...",
                "Item 10: *",
                "Item 11: lunes a la esquela",
                "Item 12: limpio el delantal",
                "Item 13: en todos labios",
                "Item 14: consol nacional"
            };

        public SSHomeCollectionViewController() : base(new UICollectionViewFlowLayout())
        {
        }

        private UICollectionViewFlowLayout _flowLayout
            => CollectionView.CollectionViewLayout as UICollectionViewFlowLayout;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CollectionView.BackgroundColor = UIColor.White;

            // Note:
            // EstimatedItemSize can be defined directly or as AutomaticSize
            // but it's necessary to set a value
            // for example, you can use the following value:
            // _flowLayout.EstimatedItemSize = new CGSize(100, 100);
            _flowLayout.EstimatedItemSize = UICollectionViewFlowLayout.AutomaticSize;
            //

            CollectionView.RegisterClassForCell(typeof(SSCollectionCell), SSCollectionCell.Key);
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
            => _items.Length;

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = collectionView.DequeueReusableCell(SSCollectionCell.Key, indexPath) as SSCollectionCell;
            cell.SetTitle(_items[indexPath.Row]);
            return cell;
        }
    }
}
