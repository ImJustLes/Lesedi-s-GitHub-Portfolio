package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.controller;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.CleanUp;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service.APIService;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service.CleanUpService;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;
import java.util.ArrayList;
import java.util.List;

//@Validated
@RestController
@RequestMapping(APIService.API_URL + "/cleanup")
public class CleanUpController {

    private CleanUpService cleanUpService;

    //Instantiating the object to access CleanUp Service CRUD methods
    @Autowired
    public CleanUpController(CleanUpService cleanUpService){
        this.cleanUpService = cleanUpService;
    }

    //Gets all the clean ups by location
    @GetMapping("/{location}")
    private ResponseEntity<List<CleanUp>> getCleanUpsFromLocation(@PathVariable String location){

        try{

            List<CleanUp> allCleanUps = cleanUpService.getAll();
            List<CleanUp> cleanUpList = new ArrayList<>();

            for (CleanUp cleanUp : allCleanUps) {
                if (cleanUp.getLocation().equals(location.toLowerCase())) {
                    cleanUpList.add(cleanUp);
                }
            }
            if(cleanUpList.isEmpty()){
                return new ResponseEntity<>(HttpStatus.NO_CONTENT);
            }
            return new ResponseEntity<>(cleanUpList, HttpStatus.OK);
        } catch (Exception ex){
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    //Saves the clean up into the database
    @PostMapping(APIService.SAVE_URL)
    private ResponseEntity<CleanUp> addCleanUp(@Valid @RequestBody CleanUp cleanUp){

        CleanUp newCleanup = cleanUpService.save(cleanUp);
        return new ResponseEntity<>(newCleanup, HttpStatus.OK);
    }

    //Updates the clean up by id with the new CleanUp information
    @PutMapping(APIService.UPDATE_URL)
    private ResponseEntity<CleanUp> updateCleanUp(@PathVariable Long id, @Valid @RequestBody CleanUp newCleanUp){

        CleanUp updatedCleanUp = cleanUpService.update(id, newCleanUp);

        if(updatedCleanUp != null){

            return new ResponseEntity<>(updatedCleanUp, HttpStatus.OK);
        }
        return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
    }

    //Deletes a clean up, by id, from the database.
    @DeleteMapping(APIService.DELETE_URL)
    private ResponseEntity<HttpStatus> deleteCleanUp(@PathVariable Long id){

        cleanUpService.deleteByID(id);
        return new ResponseEntity<>(HttpStatus.OK);
    }
}
