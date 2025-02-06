package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.controller;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.Waste;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.WasteRepo;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.*;
import org.springframework.web.bind.annotation.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

/* The @Validated annotation makes the autowired repository return null for some reason,
* which means database operations can't be done because the repo doesn't work. */
//@Validated
@RestController
public class WasteController {

    //Instantiating the waste repository to perform database operations in the controller
    @Autowired
    private WasteRepo wasteRepo;

    //Gets all the saved waste from the database
    @GetMapping("/waste")
    private ResponseEntity<List<Waste>> getAllWaste()
    {
        try{

            List<Waste> wasteList = new ArrayList<>();

            wasteRepo.findAll().forEach(wasteList::add);

            if(wasteList.isEmpty()){
                return new ResponseEntity<>(HttpStatus.NO_CONTENT);
            }
            return new ResponseEntity<>(wasteList, HttpStatus.OK);
        } catch (Exception ex){
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    //Gets a specific waste by ID from the database.
    @GetMapping("/waste/{id}")
    private ResponseEntity<Waste> getWaste(@PathVariable Long id){

        Optional<Waste> wasteOptional = wasteRepo.findById(id);

        if(wasteOptional.isPresent()){
            return new ResponseEntity<>(wasteOptional.get(), HttpStatus.OK);
        }

        return new ResponseEntity<>(HttpStatus.NOT_FOUND);
    }

    //Saves a waste from the database
    @PostMapping("/waste/save")
    private ResponseEntity<Waste> addWaste(@Valid @RequestBody Waste waste)
    {
        Waste savedWaste = wasteRepo.save(waste);

        return new ResponseEntity<>(savedWaste, HttpStatus.OK);
    }

    //Updates the current waste, selected by ID, from the database with the new inputted information.
    @PutMapping("/waste/update/{id}")
    private ResponseEntity<Waste> updateWaste(@PathVariable Long id, @Valid @RequestBody Waste newWaste)
    {
        Optional<Waste> oldWaste = wasteRepo.findById(id);

        if(oldWaste.isPresent()){
            Waste updatedWaste = oldWaste.get();
            updatedWaste.setName(newWaste.getName());
            updatedWaste.setType(newWaste.getType());
            updatedWaste.setWeight(newWaste.getWeight());

            Waste wasteData = wasteRepo.save(updatedWaste);
            return new ResponseEntity<>(wasteData, HttpStatus.OK);
        }
        return new ResponseEntity<>(HttpStatus.NOT_FOUND);
    }

    //Deletes the waste, chosen by ID
    @DeleteMapping("/waste/delete/{id}")
    private ResponseEntity<HttpStatus> deleteWaste(@PathVariable Long id)
    {
        wasteRepo.deleteById(id);
        return new ResponseEntity<>(HttpStatus.OK);
    }
}
