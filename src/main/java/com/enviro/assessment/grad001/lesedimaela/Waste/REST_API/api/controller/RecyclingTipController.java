package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.controller;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.RecyclingTipRepo;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.RecyclingTip;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

/* The @Validated annotation makes the autowired repository return null for some reason,
 * which means database operations can't be done because the repo doesn't work. */
//@Validated
@RestController
public class RecyclingTipController {

    //Instantiating the waste repository to perform database operations in the controller
    @Autowired
    private RecyclingTipRepo recyclingTipRepo;

    //Gets Recycling tips of a specific type from the database. (e.g organic will return only organic recycling tips)
    @GetMapping("/waste/{type}/tips")
    private ResponseEntity<List<RecyclingTip>> getTips(@PathVariable String type){

        try{

            //Gets all the tips from the database.
            List<RecyclingTip> allTips = recyclingTipRepo.findAll();
            List<RecyclingTip> recyclingTipsList = new ArrayList<>();

            for (RecyclingTip tip : allTips) {

                //Filters only the relevant tips of the chosen type into the list.
                if (tip.getType().equals(type.toLowerCase())) {
                    recyclingTipsList.add(tip);
                }
            }
            if(recyclingTipsList.isEmpty()){
                return new ResponseEntity<>(HttpStatus.NO_CONTENT);
            }
            return new ResponseEntity<>(recyclingTipsList, HttpStatus.OK);
        } catch (Exception ex){
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    //Saves a recycling tip into the database
    @PostMapping("/waste/tips/save")
    private ResponseEntity<RecyclingTip> addTip(@Valid @RequestBody RecyclingTip tip)
    {
        tip.setType(tip.getType().toLowerCase());
        RecyclingTip newTip = recyclingTipRepo.save(tip);

        return new ResponseEntity<>(newTip, HttpStatus.OK);
    }

    //Updates a recycling tip that exists in the database with the new tip data.
    @PutMapping("/waste/tips/update/{id}")
    private ResponseEntity<RecyclingTip> updateTip(@PathVariable Long id, @Valid @RequestBody RecyclingTip newTip)
    {
        Optional<RecyclingTip> oldTip = recyclingTipRepo.findById(id);

        if(oldTip.isPresent()){

            newTip.setType(newTip.getType().toLowerCase());
            RecyclingTip updatedTip = oldTip.get();
            updatedTip.setTip(newTip.getTip());
            updatedTip.setType(newTip.getType());

            RecyclingTip tipData = recyclingTipRepo.save(updatedTip);
            return new ResponseEntity<>(tipData, HttpStatus.OK);
        }

        return new ResponseEntity<>(HttpStatus.NOT_FOUND);
    }

    //Deletes a recycling tip by ID
    @DeleteMapping("/waste/tips/delete/{id}")
    private ResponseEntity<HttpStatus> deleteTip(@PathVariable Long id)
    {
        recyclingTipRepo.deleteById(id);
        return new ResponseEntity<>(HttpStatus.OK);
    }
}
