using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MathNet.Numerics.LinearAlgebra;

public class PCAModel 
{

    Vector<float> mean;
    Matrix<float> orthonormal_pca_basis;
    Matrix<float> rescaled_pca_basis;
    Vector<float> eigenvalues;
    

    List<int[]> triangle_list = new List<int[3]>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
