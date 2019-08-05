using CoreGraphics;
using UIKit;

namespace CollectionViewSelfSizingCells
{
    public class SSHomeViewController : UIViewController
    {
        private UICollectionView _collectionView;
        private UICollectionViewFlowLayout _flowLayout;
        private SSCollectionViewSource _collectionViewSource;

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            View.BackgroundColor = UIColor.LightGray;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _flowLayout = new UICollectionViewFlowLayout();
            _flowLayout.EstimatedItemSize = new CGSize(100, 100);
            _collectionView = new UICollectionView(CGRect.Empty, _flowLayout)
            {
                BackgroundColor = UIColor.White,
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            _collectionViewSource = new SSCollectionViewSource(_collectionView);
            _collectionView.Source = _collectionViewSource;

            View.AddSubviews(_collectionView);
            NSLayoutConstraint.ActivateConstraints(new[]
            {
                View.TopAnchor.ConstraintEqualTo(_collectionView.TopAnchor),
                View.BottomAnchor.ConstraintEqualTo(_collectionView.BottomAnchor),
                View.LeadingAnchor.ConstraintEqualTo(_collectionView.LeadingAnchor),
                View.TrailingAnchor.ConstraintEqualTo(_collectionView.TrailingAnchor),
            });
        }
    }
}
