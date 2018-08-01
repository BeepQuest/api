package main

import (
	"fmt"
	"net/http"
	"io/ioutil"
)

func main() {
	urlApi := "http://api.beepquest.com"

	client := &http.Client{}
	req, _ := http.NewRequest("GET", urlApi + "/v1/question-module-answers", nil)
	req.Header.Add("BQAPPTOK", "{BQAPPTOK}")
	req.Header.Add("BQMODTOK", "{BQMODTOK}")
	query := req.URL.Query()
	query.Add("initialDate", "2018-01-01")
	query.Add("limit", "10")
	query.Add("users", "ivan@beepquest.com,fernando@hellodave.mx")
	req.URL.RawQuery = query.Encode()

	response, err := client.Do(req)
	if err != nil {
		fmt.Print("Error: ")
		fmt.Print(err)
	} else {
		defer response.Body.Close()
		body, _ := ioutil.ReadAll(response.Body)
		if response.StatusCode == 200 {
			fmt.Print("Body: ")
		} else {
			fmt.Print("Error: ")
		}
		fmt.Print(string(body))
	}
}