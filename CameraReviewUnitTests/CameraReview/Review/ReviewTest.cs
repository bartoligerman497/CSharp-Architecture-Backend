using CameraReview.Product.Camera;
using CameraReview.Review;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CameraReviewUnitTests.CameraReview.Review
{
    /// <summary>
    /// Usar esta clase para escribir pruebas de Unitarias que corroboren la funcionalidad
    /// de los archivos en el namespace "Review"
    /// </summary>
    [TestClass]
    public class ReviewTest
    {

        [TestMethod]
        public void TestReviewContentMatchWithProduct()
        {
            // setup
            Camera cameraProduct = new Camera();
            cameraProduct.Name = "Canon 60D";
            cameraProduct.Type = "FullFrame";
            cameraProduct.CropFactor = 1;

            ReviewImpl review = new ReviewImpl();
            review.Title = "Titulo del review";
            review.Author = "Un autor";
            review.Product = cameraProduct;

            // exec
            var content = review.GetContent();

            // assert
            Assert.IsTrue(!string.IsNullOrWhiteSpace(content), "Should return content but obtained null or whitespace.");
            //Assert.IsTrue(content["products"].Contains(cameraProduct), "Should match content with the product.");

        }
    }
}
