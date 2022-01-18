using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFPS : MonoBehaviour
{

    float sight_x = 0;
    float sight_y = 0;

    void Update()
    {
        float angleH = Input.GetAxis("Horizontal2") * 5.0f;
        float angleV = Input.GetAxis("Vertical2") * 5.0f;

        if (sight_y > 80)
        {
            if (angleV < 0)
            {
                sight_y = sight_y + angleV;
            }
        }
        else if (sight_y < -90)
        {
            if (angleV > 0)
            {
                sight_y = sight_y + angleV;
            }
        }
        else
        {
            sight_y = sight_y + angleV;
        }

        if (sight_x >= 360)    //sight_x が360度を超えると360を引く、超えた分の端数はsight_xに残る
        {
            sight_x = sight_x - 360;
        }
        else if (sight_x < 0)  //sight_x が0度を下回ると360からsight_xを引く、残った分はsight_xに残る
        {
            sight_x = 360 - sight_x;
        }
        sight_x = sight_x + angleH;
        transform.localRotation = Quaternion.Euler(sight_y, sight_x, 0);
    }

}
