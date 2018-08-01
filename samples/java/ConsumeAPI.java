/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package consumeapi;

import java.io.BufferedInputStream;
import java.io.InputStream;
import java.net.URL;
import java.net.URLConnection;

/**
 *
 * @author P@kito ConK <zurdokw@gmail.com>
 */
public class ConsumeAPI {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        try{

                // TODO code application logic here
                URL url= new URL("http://api.beepquest.com/v1/question-module-answers?initialDate=2018-01-01&limit=10");
                URLConnection urlConnection = url.openConnection();
                urlConnection.addRequestProperty("BQAPPTOK","xxxxxxx");
                urlConnection.addRequestProperty("BQMODTOK","yyyyyyy");
                InputStream input = new BufferedInputStream(urlConnection.getInputStream());    
                System.out.println("Respuesta:" + input.toString());
            }
        catch(Exception e){
            System.out.println("Error:"+e.toString());
        }
        
    }
    
}
