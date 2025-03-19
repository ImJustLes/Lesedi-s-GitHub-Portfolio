package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.controller;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.Waste;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service.APIService;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service.WasteService;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

/* The @Validated annotation makes the autowired repository return null for some reason,
* which means database operations can't be done because the repo doesn't work. */
//@Validated
@RestController
@RequestMapping(APIService.API_URL + "/waste")
public class WasteController {

    private WasteService wasteService;

    //Instantiating the waste repository to perform database operations in the controller
    @Autowired
    private WasteController(WasteService wasteService){
        this.wasteService = wasteService;
    }

    //Gets all the saved waste from the database
    @GetMapping()
    private ResponseEntity<List<Waste>> getAllWaste()
    {
        try{

            List<Waste> wasteList = new ArrayList<>();

            wasteList.addAll(wasteService.getAll());

            if(wasteList.isEmpty()){
                return new ResponseEntity<>(HttpStatus.NO_CONTENT);
            }
            return new ResponseEntity<>(wasteList, HttpStatus.OK);
        } catch (Exception ex){
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    //Gets a specific waste by ID from the database.
    @GetMapping("/{id}")
    private ResponseEntity<Waste> getWaste(@PathVariable Long id){

        Optional<Waste> wasteOptional = wasteService.getByID(id);

        if(wasteOptional.isPresent()){
            return new ResponseEntity<>(wasteOptional.get(), HttpStatus.OK);
        }

        return new ResponseEntity<>(HttpStatus.NOT_FOUND);
    }

    //Saves a waste from the database
    @PostMapping(APIService.SAVE_URL)
    private ResponseEntity<Waste> addWaste(@Valid @RequestBody Waste waste)
    {
        Waste savedWaste = wasteService.save(waste);
        return new ResponseEntity<>(savedWaste, HttpStatus.OK);
    }

    //Updates the current waste, selected by ID, from the database with the new inputted information.
    @PutMapping(APIService.UPDATE_URL)
    private ResponseEntity<Waste> updateWaste(@PathVariable Long id, @Valid @RequestBody Waste newWaste)
    {
        Waste updatedWaste = wasteService.update(id, newWaste);

        if(updatedWaste != null){

            return new ResponseEntity<>(updatedWaste, HttpStatus.OK);
        }
        return new ResponseEntity<>(HttpStatus.NOT_FOUND);
    }

    //Deletes the waste, chosen by ID
    @DeleteMapping(APIService.DELETE_URL)
    private ResponseEntity<HttpStatus> deleteWaste(@PathVariable Long id)
    {
        wasteService.deleteByID(id);
        return new ResponseEntity<>(HttpStatus.OK);
    }
}
