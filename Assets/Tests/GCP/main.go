package main

import (
	"net/http"

	ase "github.com/GameWorkstore/async-network-engine-go"
)

// Process handler of this test
func Process(w http.ResponseWriter, r *http.Request) {
	rqt := ase.GenericRequest{}
	if ase.GCPDecode(r, w, &rqt) {
		return
	}
	resp := ase.GenericResponse{}
	resp.Messege = "Received:" + rqt.Messege
	ase.GCPResponse(w, &resp)
}
